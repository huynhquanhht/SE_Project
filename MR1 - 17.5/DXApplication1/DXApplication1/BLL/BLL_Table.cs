using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.DAL
{
    class BLL_Table
    {
        private static BLL_Table _Instance;
        internal static BLL_Table Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_Table();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }
        public object Show_BLL()
        {
            return DAL_Table.Instance.Show_DAL();
        }
        public object Search_BLL(string str_Search)
        {

            return DAL_Table.Instance.Search_DAL(str_Search);
        }
        public bool Add_BLL(string name_Table, bool status)
        {
            return DAL_Table.Instance.Add_DAL(name_Table,  status);
        }
        public bool Update_BLL(int Id, string name_Table, bool status_Update)
        {
            return DAL_Table.Instance.Update_DAL(Id, name_Table, status_Update);
        }
        public bool Delete_BLL(List<int> list_Dell)
        {
            if (DAL_Table.Instance.Delete_DAL(list_Dell))
                return true;
            else
                return false;
        }
    


    }
}
