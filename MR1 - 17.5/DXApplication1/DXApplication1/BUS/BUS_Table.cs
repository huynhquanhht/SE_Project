using DXApplication1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.DAL
{
    public class BUS_Table
    {
        private BUS_Table() { }
        private static BUS_Table _Instance;
        public static BUS_Table Instance
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
                catch (Exception)
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
                catch (Exception)
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
                catch
                {
                    return false;
                }

            }
        }

        public bool AddTable(string name_Table)
        {
            using (SE_08 db = new SE_08())
            {
                try
                {
                    if (db.Tables.Where(p => p.Name == name_Table && p.Is_Deleted == false).ToList().Count >= 1)
                    {
                        return false;
                    }
                    else
                    {
                        var data = db.Tables.Add(new Table { Name = name_Table, Status = false });
                    }
                    return db.SaveChanges() > 0;

                }
                catch
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
                catch
                {
                    return false;
                }
            }
        }

        public bool UpdateTable(int Id, string name_Update)
        {
            using (SE_08 db = new SE_08())
            {
                try
                {
                    var q = db.Tables.Where(p => p.Id == Id).Select(p => p).FirstOrDefault();
                    q.Name = name_Update;
                    return db.SaveChanges() > 0;

                }
                catch
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
                listTable = db.Tables.Where(p => p.Is_Deleted == false).Select(p => p).ToList();
            }
            return listTable;
        }

        public bool UpdateIDTableOfBillByIDTable(int IDTable1, int IDTable2)
        {
            SE_08 db = new SE_08();
            int IDBill1 = BUS_Bill.Instance.GetIDBillByIDTable(IDTable1);
            BUS_Table.Instance.SetStatusTableByIDTable(IDTable1, false);
            BUS_Table.Instance.SetStatusTableByIDTable(IDTable2, true);
            var q = db.Bills.Where(p => p.Id == IDBill1).Select(p => p).FirstOrDefault();
            q.Id_Table = IDTable2;

            return db.SaveChanges() > 0;
        }
        public String GetNameTableByIDTable(int IDTable)
        {
            using (SE_08 db = new SE_08())
            {
                return db.Tables.Where(p => p.Id == IDTable && p.Is_Deleted == false).Select(p => p.Name).FirstOrDefault();
            }
        }
        public int CountTable()
        {
            using (SE_08 db = new SE_08())
            {
                return db.Tables.Where(p => p.Is_Deleted == false).Count();
            }
            #endregion
        }
        public bool SetStatusTableByIDBill(int IDBill, bool Status)
        {
            SE_08 db = new SE_08();
            var t = db.Bills.Where(p => p.Id == IDBill && p.Status == false && p.Is_Deleted == false).Select(p => p).FirstOrDefault();
            var q = db.Tables.Where(p => p.Id == t.Id_Table).Select(p => p).FirstOrDefault();
            q.Status = Status;
            return db.SaveChanges() > 0;
        }
        public bool SetStatusTableByIDTable(int IDTable, bool Status)
        {
            SE_08 db = new SE_08();
            var q = db.Tables.Where(p => p.Id == IDTable).Select(p => p).FirstOrDefault();
            q.Status = Status;
            return db.SaveChanges() > 0;
        }

        public Table GetTableByIDTable(int IDTable)
        {
            SE_08 db = new SE_08();
            return db.Tables.Where(p => p.Id == IDTable).Select(p => p).FirstOrDefault();
        }
    }
}
