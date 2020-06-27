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
        internal static BUS_BillInfo Instance
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
    }

    //public object Getnt Id_Type)
    //{
    //    using (SE_08 db = new SE_08())
    //    {
    //        try
    //        {
    //            if (Id_Type == 0)
    //            {
    //                var data = db.Accounts.Select(p => new { Id = p.Id, Name = p.Employee.Name, p.Employee.Phone, p.Username, p.Password, NameType = p.TypeAccount.Name }).ToList();
    //                return data;

    //            }
    //            else
    //            {
    //                var data = db.Accounts.Where(p => p.Id_Type == Id_Type).Select(p => new { Id = p.Id, Name = p.Employee.Name, p.Employee.Phone, p.Username, p.Password, NameType = p.TypeAccount.Name }).ToList();
    //                return data;
    //            }
    //        }
    //        catch (Exception)
    //        {
    //            return null;
    //        }
    //    }
    //}
}
