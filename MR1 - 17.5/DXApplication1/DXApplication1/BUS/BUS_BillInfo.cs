using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.DAL
{
    public class BUS_BillInfo
    {
        private BUS_BillInfo() { }
        private static BUS_BillInfo _Instance;
        public static BUS_BillInfo Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BUS_BillInfo();
                }
                return _Instance;
            }
            private set => _Instance = value;
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
                        return db.BillInfos.Where(p => p.Id_Bill == IDBill && p.Bill.Status == false).Sum(p => p.Amount * p.Item.Price);
                    }
                }
            }
            catch
            { }
            return 0;

        }
        public object GetBillInfoDetail(int IDTable)
        {
            SE_08 db = new SE_08();
            int IDBill = BUS_Bill.Instance.GetIDBillByIDTable(IDTable);
            object listBillInfo = db.BillInfos.Where(p => p.Id_Bill == IDBill && p.Bill.Id_Table == IDTable && p.Bill.Status == false).Select(p => new { p.Item.Name, p.Amount, p.Item.Price, Total = p.Amount * p.Item.Price }).ToList();
            return listBillInfo;
        }

        public Object GetBillInfoByIDBill(int IDBill)
        {
            try
            {
                SE_08 db = new SE_08();
                return db.BillInfos.Where(p => p.Id_Bill == IDBill).Select(p => new { Name = p.Item.Name,Amount =  p.Amount, Price = p.Item.Price, Total = p.Amount * p.Item.Price}).ToList();
            }
            catch { return null; }
        }
    }
}
