﻿using DXApplication1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.DAL
{
    class DAL_Category
    {
       
        private static DAL_Category _Instance;
        internal static DAL_Category Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_Category();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }
        public object Show_DAL()
        {
            using (SE_08 db = new SE_08())
            {

                var data = db.Categories.Where(p => p.Is_Deleted == false).Select(p => new { p.Id, p.Name }).ToList();
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
                var data = db.Categories.Where(p => ((p.Id).ToString().Contains(str_Search) || (p.Name).Contains(str_Search)) && p.Is_Deleted == false).ToList();
                if (data.Count != 0)
                    return data;
                else
                    return null;
            }
        }
        public bool Add_DAL(string name_Category)
        {
            using (SE_08 db = new SE_08())
            {
                try
                {
                    if (db.Categories.Where(p => p.Name == name_Category && p.Is_Deleted == true).ToList().Count == 1)
                    {
                        Category category = db.Categories.Where(p => p.Name == name_Category).SingleOrDefault();
                        category.Is_Deleted = false;
                    }
                    else
                    {
                        var data = db.Categories.Add(new Category { Name = name_Category });
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
        public bool Update_DAL(int Id, string name_Update)
        {
            using (SE_08 db = new SE_08())
            {
                try
                {
                    Category category = db.Categories.SingleOrDefault(p => p.Id == Id);
                    category.Name = name_Update;
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
                foreach (int i in list_Del)
                {
                    Category category = db.Categories.Single(p => p.Id == i);
                    category.Is_Deleted = true;
                }
                db.SaveChanges();
                return true;
            }
        }
    }
}
