using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.DAL
{
    class BUS_Bill
    {
        private BUS_Bill(){}
        private static BUS_Bill _Instance;
        internal static BUS_Bill Instance
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
    }
}
