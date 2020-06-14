using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.DAL
{
    class BLL_Employee
    {
        private static BLL_Employee _Instance;
        internal static BLL_Employee Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_Employee();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }
        public object Show_BLL()
        {
            return DAL_Employee.Instance.Show_DAL();
        }

        public object Search_BLL(string str_Search)
        {

            return DAL_Employee.Instance.Search_DAL(str_Search);
        }
    }
}
