using DXApplication1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.DAL
{
    public class BUS_Item
    {
        private BUS_Item() { }
        private static BUS_Item _Instance;
        public static BUS_Item Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BUS_Item();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }
        
        public object Show_DAL(int Id_Category = 0)
        {
            using (SE_08 db = new SE_08())
            {
                if (Id_Category == 0)
                {
                    try
                    {
                        var data = db.Items.Where(p => p.Is_Deleted == false).Select(p => new { Id = p.Id, Name = p.Name, Price = p.Price, Name_Category = p.Category.Name }).ToList();
                        return data;
                    }
                    catch (Exception)
                    {
                        return null;
                    }

                }
                else
                {
                    try
                    {
                        var data = db.Items.Where(p => p.Is_Deleted == false && p.Id_Category == Id_Category).Select(p => new { p.Id, p.Name, p.Price }).ToList();
                        return data;
                    }
                    catch (Exception)
                    {
                        return null;
                    }
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
                        var data = db.Items.Add(new Item { Name = name_Item, Id_Category = Id_Category, Price = price_Item });
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
        public bool Delete_DAL(List<int> list_Del)
        {

            using (SE_08 db = new SE_08())
            {
                try
                {
                    foreach (int i in list_Del)
                    {
                        Item item = db.Items.Single(p => p.Id == i);
                        item.Is_Deleted = true;
                    }
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }

            }
        }
        public List<DTO.Item> GetListFoodByIDCategory(int IDCategory)
        {
            List<DTO.Item> listFood = new List<DTO.Item>();
            using (SE_08 db = new SE_08())
            {
                listFood = db.Items.Where(p => p.Id_Category == IDCategory).Select(p => p).ToList();
            }
            return listFood;
        }

        #region GET
        public bool AddFood(int IDBill, int IDFood, int amount)
        {
            try
            {
                using (SE_08 db = new SE_08())
                {
                    int cnt = db.BillInfos.Where(p => p.Id_Item == IDFood && p.Id_Bill == IDBill).Count();
                    if (cnt <= 0 && amount > 0)
                    {
                        db.BillInfos.Add(new BillInfo { Id_Bill = IDBill, Id_Item = IDFood, Amount = amount });
                    }
                    else if (cnt > 0)
                    {
                        var q = db.BillInfos.Where(p => p.Id_Item == IDFood && p.Id_Bill == IDBill).Select(p => p).FirstOrDefault();
                        if (q.Amount + amount <= 0)
                        {
                            db.BillInfos.Remove(q);
                        }
                        else
                        {
                            q.Amount += amount;
                        }
                    }
                    return db.SaveChanges() > 0;
                }
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);
                //MessageBox.Show("Có lỗi trong quá trình thêm món");
                return false;
            }
        }


        #endregion
    }
}
