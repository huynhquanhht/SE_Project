using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.DAL
{
    class DAL_Employee
    {
        private static DAL_Employee _Instance;
        internal static DAL_Employee Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_Employee();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }
        public object Show_DAL()
        {
            using (SE_08 db = new SE_08())
            {

                var data = db.Employees.Where(p => p.Is_Deleted == false).Select(p => new { p.Id, p.Name, p.Birthday, p.Address, p.Phone, p.Id_Account}).ToList();
                if (data.Count != 0)
                    return data;
                else
                    return null;
            }
        }
     
        public object Search_DAL(string str_Search)
        {

            using (SE_08 db = new SE_08())
            {
                var data = db.Employees.Where(p => ((p.Id).ToString().Contains(str_Search) || (p.Name).Contains(str_Search) || p.Birthday.ToString().Contains(str_Search) || p.Address.Contains(str_Search) || p.Phone.Contains(str_Search) || p.Id_Account.ToString().Contains(str_Search)) && p.Is_Deleted == false).ToList();
                if (data.Count != 0)
                    return data;
                else
                    return null;
            }
        }
    }
}
