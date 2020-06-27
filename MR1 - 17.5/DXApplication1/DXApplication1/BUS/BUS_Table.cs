using DXApplication1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.DAL
{
    class BUS_Table
    {
        private BUS_Table() { }
        private static BUS_Table _Instance;
        internal static BUS_Table Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BUS_Table();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }
        public object Show_DAL()
        {
            using (SE_08 db = new SE_08())
            {
                try
                {
                    var data = db.Tables.Where(p => p.Is_Deleted == false).Select(p => new { p.Id, p.Name, p.Status }).ToList();
                    if (data.Count != 0)
                        return data;
                    else
                        return null;
                }
                catch(Exception)
                {
                    return null;
                }
            }
        }
        public object Search_DAL(string str_Search)
        {

            using (SE_08 db = new SE_08())
            {
                try
                {
                    var data = db.Tables.Where(p => ((p.Id).ToString().Contains(str_Search) || (p.Name).Contains(str_Search)) && p.Is_Deleted == false).ToList();
                    if (data.Count != 0)
                        return data;
                    else
                        return null;
                }
                catch(Exception)
                {
                    return null;
                }
            }
        }
        public bool Add_DAL(string name_Table, bool status)
        {
            using (SE_08 db = new SE_08())
            {
                try
                {
                    if (db.Tables.Where(p => p.Name == name_Table && p.Is_Deleted == true).ToList().Count == 1)
                    {
                        Table table = db.Tables.Where(p => p.Name == name_Table).SingleOrDefault();
                        table.Is_Deleted = false;
                        table.Status = status;
                    }
                    else
                    {
                        var data = db.Tables.Add(new Table { Name = name_Table, Status = status });
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
        public bool Update_DAL(int Id, string name_Update, bool status_Update)
        {
            using (SE_08 db = new SE_08())
            {
                try
                {
                    Table table = db.Tables.SingleOrDefault(p => p.Id == Id);
                    table.Name = name_Update;
                    table.Status = status_Update;
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
            int key = 0;
            using (SE_08 db = new SE_08())
            {
                try
                {
                    foreach (int i in list_Del)
                    {
                        if (db.Tables.Where(p => p.Id == i && p.Status == false).ToList().Count == 1)
                        {
                            Table table = db.Tables.Single(p => p.Id == i);
                            table.Is_Deleted = true;
                        }
                        if (db.Tables.Where(p => p.Id == i && p.Status == true).ToList().Count == 1)
                        {
                            key = 1;
                            break;
                        }
                    }
                    if (key == 1)
                    {
                        return false;
                    }
                    else
                    {
                        db.SaveChanges();
                        return true;
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        #region GET
        public List<DTO.Table> GetListTable()
        {
            List<DTO.Table> listTable = new List<DTO.Table>();
            using (SE_08 db = new SE_08())
            {
                listTable = db.Tables.Select(p => p).ToList();
            }
            return listTable;
        }
        #endregion
    }
}
