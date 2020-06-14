using DXApplication1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.DAL
{
    class BLL_Category
    {
        private static BLL_Category _Instance;
        internal static BLL_Category Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_Category();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }
        public object Show_BLL()
        {
            return DAL_Category.Instance.Show_DAL();
        }
        public object Search_BLL(string str_Search)
        {

            return DAL_Category.Instance.Search_DAL(str_Search);
        }
        public bool Add_BLL(string name_Category)
        {
            return DAL_Category.Instance.Add_DAL(name_Category);
        }
        public bool Update_BLL(int Id, string name_Category)
        {
            return DAL_Category.Instance.Update_DAL(Id, name_Category);
        }
        public bool Delete_BLL(List<int> list_Dell)
        {
            if (DAL_Category.Instance.Delete_DAL(list_Dell))
                return true;
            else
                return false;
        }
    }
}
