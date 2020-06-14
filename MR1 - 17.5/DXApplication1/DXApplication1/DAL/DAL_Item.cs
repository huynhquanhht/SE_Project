using DXApplication1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.DAL
{
    class DAL_Item
    {
        private static DAL_Item _Instance;
        internal static DAL_Item Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_Item();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }
        public object Show_DAL(int Id_Category)
        {
            using (SE_08 db = new SE_08())
            {
                if(Id_Category == 0)
                {
                    var data = db.Items.Where(p => p.Is_Deleted == false).Select(p => new { Id = p.Id, Name = p.Name, Price = p.Price, Name_Category = p.Category.Name}).ToList();
                    return data;

                }
                else
                {
                    var data = db.Items.Where(p => p.Is_Deleted == false && p.Id_Category == Id_Category).Select(p => new { p.Id, p.Name, p.Price }).ToList();
                        return data;
                }
                
            }
        }
        public IEnumerable<dynamic> GetCategory_DAL()
        {
            using (SE_08 db = new SE_08())
            {
                IEnumerable<dynamic> list_Category = db.Categories.Where(p => p.Is_Deleted == false).Select(p => new { p.Id, p.Name }).ToList();
                return list_Category;
            }
       
        }
        public bool Add_DAL(string name_Item, int Id_Category, int price_Item)
        {
            using (SE_08 db = new SE_08())
            {
                try
                {
                    if (db.Items.Where(p => p.Name == name_Item && p.Is_Deleted == true).ToList().Count == 1)
                    {
                        Item item = db.Items.Where(p => p.Name == name_Item).SingleOrDefault();
                        item.Is_Deleted = false;
                    }
                    else
                    {
                        var data = db.Items.Add(new Item { Name = name_Item, Id_Category = Id_Category, Price = price_Item});
                    }
                    db.SaveChanges();
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }

            }
        }
        public object Search_DAL(int Id_Category, string str_Search)
        {

            using (SE_08 db = new SE_08())
            {
                if (str_Search == "")
                {
                    if (Id_Category == 0)
                    {
                        var data = db.Items.Where(p => p.Is_Deleted == false).Select(p => new { Id = p.Id, Name = p.Name, Price = p.Price, Name_Category = p.Category.Name }).ToList();
                        return data;
                    }
                    else
                    {
                        var data = db.Items.Where(p => p.Is_Deleted == false && p.Id_Category == Id_Category).Select(p => new { Id = p.Id, Name = p.Name, Price = p.Price, Name_Category = p.Category.Name }).ToList();
                        return data;
                    }
                }
                else
                {
                    if (Id_Category == 0)
                    {
                        var data = db.Items.Where(p => p.Is_Deleted == false && (((p.Id).ToString().Contains(str_Search) || (p.Name).Contains(str_Search)) || (p.Price).ToString().Contains(str_Search)))
                                          .Select(p => new { Id = p.Id, Name = p.Name, Price = p.Price, Name_Category = p.Category.Name }).ToList();
                        if (data.Count == 0)
                            return null;
                        else
                            return data;
                    }
                    else
                    {

                        var data = db.Items.Where(p => p.Id_Category == Id_Category && p.Is_Deleted == false && (((p.Id).ToString().Contains(str_Search) || (p.Name).Contains(str_Search)) || (p.Price).ToString().Contains(str_Search)))
                                          .Select(p => new { Id = p.Id, Name = p.Name, Price = p.Price, Name_Category = p.Category.Name }).ToList();
                        if (data.Count == 0)
                            return null;
                        else
                            return data;
                    }
                }
            }
        }
        public bool Delete_DAL(List<int> list_Del)
        {

            using (SE_08 db = new SE_08())
            {
                foreach (int i in list_Del)
                {
                    Item item = db.Items.Single(p => p.Id == i);
                    item.Is_Deleted = true;
                }
                db.SaveChanges();
                return true;
            }
        }
        public bool Update_DAL(int Id, string name_Update, int Id_Category_Update, int price_Update)
        {
            using (SE_08 db = new SE_08())
            {
                try
                {
                    Item item = db.Items.SingleOrDefault(p => p.Id == Id);
                    item.Name = name_Update;
                    item.Id_Category = Id_Category_Update;
                    item.Price = price_Update;
                    db.SaveChanges();
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }

            }
        }
    }
}
