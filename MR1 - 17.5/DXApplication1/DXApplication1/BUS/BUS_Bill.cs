using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.DAL
{
    public class BUS_Bill
    {
        private BUS_Bill() { }
        private static BUS_Bill _Instance;
        public static BUS_Bill Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BUS_Bill();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }
        public int GetIDBillByIDTable(int IDTable)
        {
            using (SE_08 db = new SE_08())
            {
                var q = db.Bills.Where(p => p.Id_Table == IDTable && p.Is_Deleted == false && p.Status == false).Select(p => p.Id).FirstOrDefault();

                return q;
            }
        }
        public bool UpdateIDBillOfBillInfoByIDBill(int IDTable1, int IDTable2)
        {
            if (IDTable1 == IDTable2) return false;
            SE_08 db = new SE_08();
            BUS_Table.Instance.SetStatusTableByIDTable(IDTable1, false);
            BUS_Table.Instance.SetStatusTableByIDTable(IDTable2, true);
            int IDBill1 = BUS_Bill.Instance.GetIDBillByIDTable(IDTable1);
            int IDBill2 = BUS_Bill.Instance.GetIDBillByIDTable(IDTable2);
            var q = db.BillInfos.Where(p => p.Id_Bill == IDBill1).Select(p => p);
            foreach (var item in q)
            {
                BUS_Item.Instance.AddFood(IDBill2, item.Id_Item, item.Amount);
            }
            var d = db.Bills.Where(p => p.Id == IDBill1).Select(p => p).FirstOrDefault();
            db.Bills.Remove(d);
            return db.SaveChanges() > 0;
        }
        public bool Pay(int IDTable)
        {
            try
            {
                int IDBill = BUS_Bill.Instance.GetIDBillByIDTable(IDTable);
                BUS_Table.Instance.SetStatusTableByIDTable(IDTable, false);
                using (SE_08 db = new SE_08())
                {
                    var q = db.Bills.Where(p => p.Id == IDBill && p.Status == false).Select(p => p).FirstOrDefault();
                    q.Status = true;
                    return db.SaveChanges() > 0;
                }
            }
            catch
            {

                return false;
            }
        }

        public bool RemoveBill(int IDTable)
        {
            try
            {
                int IDBill = BUS_Bill.Instance.GetIDBillByIDTable(IDTable);
                BUS_Table.Instance.SetStatusTableByIDTable(IDTable, false);
                using (SE_08 db = new SE_08())
                {
                    //MessageBox.Show("Count: " + db.BillInfos.Where(p => p.Id_Bill == IDBill).Count().ToString());
                    var y = db.Bills.Where(p => p.Id == IDBill).Select(p => p).FirstOrDefault();
                    db.Bills.Remove(y);
                    return db.SaveChanges() > 0;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool RemoveBillNotExistItem(int IDTable)
        {
            try
            {
                int IDBill = BUS_Bill.Instance.GetIDBillByIDTable(IDTable);

                using (SE_08 db = new SE_08())
                {
                    //MessageBox.Show("Count: " + db.BillInfos.Where(p => p.Id_Bill == IDBill).Count().ToString());
                    if (db.BillInfos.Where(p => p.Id_Bill == IDBill).Count() <= 0)
                    {
                        var y = db.Bills.Where(p => p.Id == IDBill).Select(p => p).FirstOrDefault();
                        db.Bills.Remove(y);
                    }

                    return db.SaveChanges() > 0;
                }
            }
            catch
            {
                return false;
            }
        }
        public bool AddBill(int iDTable, int IDEmolyee, int discount)
        {
            try
            {
                using (SE_08 db = new SE_08())
                {
                    db.Bills.Add(new DTO.Bill { Id_Table = iDTable, Id_Employee = IDEmolyee, Date_Order = DateTime.Now, Date_Pay = DateTime.Now, Discount = discount });

                    return db.SaveChanges() > 0;
                }
            }
            catch
            {
                return false;
            }

        }

        public int GetTotal(int month, int year)
        {
            SE_08 db = new SE_08();
            try
            {
                int q = db.BillInfos.Where(p => p.Bill.Is_Deleted == false && p.Bill.Status == true && p.Bill.Date_Pay.Month == month && p.Bill.Date_Pay.Year == year).Sum(x => x.Amount * x.Item.Price);
                int discount = db.Bills.Where(p => p.Is_Deleted == false && p.Status == true && p.Date_Pay.Month == month && p.Date_Pay.Year == year).Select(p => p.Discount).FirstOrDefault();
                return q / 100 * (100 - discount);
            }
            catch { return 0; }
        }

        public int GetCntBill(int month, int year)
        {
            try
            {
                SE_08 db = new SE_08();
                return db.Bills.Where(p => p.Status == true && p.Is_Deleted == false && p.Date_Pay.Month == month && p.Date_Pay.Year == year).Count(); ;
            }
            catch { return 0; }
        }

        public int GetCntDrink(int month, int year)
        {
            try
            {
                SE_08 db = new SE_08();
                return db.BillInfos.Where(p => p.Item.Category.Id == 5 && p.Bill.Status == true && p.Bill.Is_Deleted == false && p.Bill.Date_Pay.Month == month && p.Bill.Date_Pay.Year == year).Select(p => p.Amount).Sum();
            }
            catch
            {
                return 0;
            }
        }

        public int GetCntFood(int month, int year)
        {
            try
            {
                SE_08 db = new SE_08();
                return db.BillInfos.Where(p => p.Item.Category.Id != 5 && p.Bill.Status == true && p.Bill.Is_Deleted == false && p.Bill.Date_Pay.Month == month && p.Bill.Date_Pay.Year == year).Select(p => p.Amount).Sum();
            }
            catch
            {
                return 0;
            }
        }



        public Object GetBillDetail()
        {
            try
            {
                SE_08 db = new SE_08();
                var q = db.Bills.Select(p => new { IDBill = p.Id, DateOrder = p.Date_Order, DatePay = p.Date_Pay, Discount = p.Discount + "%", TableName = p.Table.Name, SatusBill = p.Status, Tmp = p.Items.Sum(x => x.Amount * x.Item.Price), StatusBill = p.Status, Employee = p.Employee.Name, Total = p.Items.Sum(x => x.Amount * x.Item.Price / 100 * (100 - x.Bill.Discount)) }).ToList();

                return q;
            }
            catch { return null; }
        }


        public bool DelBill(int IDBill)
        {
            SE_08 db = new SE_08();
            var q = db.Bills.Where(p => p.Id == IDBill).Select(p => p).FirstOrDefault();
            q.Is_Deleted = true;
            return db.SaveChanges() > 0;
        }

        public bool SetDiscount(int IDTable, int discount)
        {
            try
            {
                SE_08 db = new SE_08();
                var q = db.Bills.Where(p => p.Id_Table == IDTable && p.Status == false && p.Is_Deleted == false).Select(p => p).FirstOrDefault();
                q.Discount = discount;
                return db.SaveChanges() > 0;
            }
            catch { return false; }
        }
        public int GetTotalPrice(int IDTable)
        {
            try
            {
                int IDBill = BUS_Bill.Instance.GetIDBillByIDTable(IDTable);
                if (IDBill != 0)
                {
                    using (SE_08 db = new SE_08())
                    {
                        int discount = db.Bills.Where(p => p.Id == IDBill && p.Status == false).Select(p => p.Discount).FirstOrDefault();
                        return db.BillInfos.Where(p => p.Id_Bill == IDBill && p.Bill.Status == false).Sum(p => p.Amount * p.Item.Price) / 100 * (100 - discount);
                    }
                }
            }
            catch
            { }
            return 0;

        }
        public object Search_DAL(string str_Search)
        {

            str_Search = str_Search.Trim();
            using (SE_08 db = new SE_08())
            {
                DateTime dt;
                string[] validformats = new[] { "dd/MM/yyyy", "d/M/yyyy", "MM/dd/yyyy", "yyyy/MM/dd", "M/d/yyyy", "yyyy/M/d", "MM-dd-yyyy", "yyyy-MM-dd", "M-d-yyyy", "d-M-yyyy", "yyyy-M-d", "MM dd yyyy", "yyyy MM dd", "M d yyyy", "d M yyyy", "yyyy M d", "dd MM yyyy" };
                CultureInfo provider = CultureInfo.InvariantCulture;
                DateTime.TryParseExact(str_Search, validformats, provider, DateTimeStyles.None, out dt);
                try
                {
                    var data = db.Bills.Where(
                        p => (
                            p.Id.ToString().Contains(str_Search)
                        || p.Table.Name.Contains(str_Search)
                        || p.Items.Sum(x => x.Amount * x.Item.Price).ToString().Contains(str_Search)
                        || p.Employee.Name.Contains(str_Search)
                        || p.Date_Order.Day.ToString().Contains(str_Search)
                        || p.Date_Order.Month.ToString().Contains(str_Search)
                        || p.Date_Order.Year.ToString().Contains(str_Search)
                        || p.Date_Pay.Day.ToString().Contains(str_Search)
                        || p.Date_Pay.Month.ToString().Contains(str_Search)
                        || p.Date_Pay.Year.ToString().Contains(str_Search)
                        || (p.Date_Pay.Day == dt.Day && p.Date_Pay.Month == dt.Month && p.Date_Pay.Year == dt.Year)
                        || (p.Date_Order.Day == dt.Day && p.Date_Order.Month == dt.Month && p.Date_Order.Year == dt.Year)
                        )
                        && p.Is_Deleted == false).Select(p => new { Tmp = p.Items.Sum(x => x.Amount * x.Item.Price), IDBill = p.Id, DateOrder = p.Date_Order, DatePay = p.Date_Pay, TableName = p.Table.Name, Discount = p.Discount, Total = p.Items.Sum(x => x.Amount * x.Item.Price) / 100 * (100 - p.Discount), StatusBill = p.Status, Employee = p.Employee.Name }).ToList();

                    if (data.Count != 0)
                        return data;
                    else
                        return null;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
    }
}