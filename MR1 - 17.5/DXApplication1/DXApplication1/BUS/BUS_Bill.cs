using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.DAL
{
    public class BUS_Bill
    {
        private BUS_Bill(){}
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
        public bool UpdateIDBillOfBillInfoByIDBill(int IDBill1, int IDBill2)
        {
            SE_08 db = new SE_08();
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
                using (SE_08 db = new SE_08())
                {
                    var q = db.Bills.Where(p => p.Id == IDBill && p.Status == false).Select(p => p).FirstOrDefault();
                    q.Status = true;
                    return db.SaveChanges() > 0;
                }
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);
                //MessageBox.Show("Xảy ra lỗi khi thanh toán");
                return false;
            }
        }

        public bool RemoveBill(int IDTable)
        {
            try
            {
                int IDBill = BUS_Bill.Instance.GetIDBillByIDTable(IDTable);
                using (SE_08 db = new SE_08())
                {
                    //MessageBox.Show("Count: " + db.BillInfos.Where(p => p.Id_Bill == IDBill).Count().ToString());
                    var y = db.Bills.Where(p => p.Id == IDBill).Select(p => p).FirstOrDefault();
                    db.Bills.Remove(y);
                    return db.SaveChanges() > 0;
                }
            }
            catch (Exception e)
            {
                // MessageBox.Show(e.Message);
                //  MessageBox.Show("Có lỗi xảy ra khi huỷ hoá đơn");
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
            catch (Exception e)
            {
                // MessageBox.Show(e.Message);
                // MessageBox.Show("Có lỗi xảy ra khi xoá hoá đơn");
                return false;
            }
        }
        public bool AddBill(int iDTable, int IDEmolyee)
        {
            try
            {
                using (SE_08 db = new SE_08())
                {
                    db.Bills.Add(new DTO.Bill { Id_Table = iDTable, Id_Employee = IDEmolyee, Date_Order = DateTime.Now, Date_Pay = DateTime.Now });

                    return db.SaveChanges() > 0;
                }
            }
            catch (Exception e)
            {

                // MessageBox.Show(e.Message);
                // MessageBox.Show("Có lỗi khi tạo mới hoá đơn");
                return false;
            }
        }
    }
}
