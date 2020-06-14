using DXApplication1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.DAL
{
    class BLL_Item
    {
        private static BLL_Item _Instance;
        internal static BLL_Item Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_Item();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }
        public IEnumerable<dynamic> GetCategory_BLL()
        {
            return DAL_Item.Instance.GetCategory_DAL();
        }
        public object Show_BLL(int Id_Category)
        {
            return DAL_Item.Instance.Show_DAL(Id_Category);
        }
        public object Search_BLL(int Id_Category, string str_Search)
        {
            return DAL_Item.Instance.Search_DAL(Id_Category, str_Search);
        }
        public bool Add_BLL(string name_Item, int Id_Category, int  price_Item)
        {
            return DAL_Item.Instance.Add_DAL(name_Item, Id_Category, price_Item);
        }
        public bool Delete_BLL(List<int> list_Dell)
        {
            if (DAL_Item.Instance.Delete_DAL(list_Dell))
                return true;
            else
                return false;
        }
        public bool Update_BLL(int Id,string name_Update, int Id_Category_Update, int price_Update)
        {
            return DAL_Item.Instance.Update_DAL( Id,  name_Update,  Id_Category_Update,  price_Update);
        }
    }
}
