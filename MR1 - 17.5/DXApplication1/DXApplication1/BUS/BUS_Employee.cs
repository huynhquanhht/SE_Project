using DXApplication1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.DAL
{
    public class BUS_Employee
    {
        private BUS_Employee() { }
        private static BUS_Employee _Instance;
        internal static BUS_Employee Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BUS_Employee();
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
                    var data = db.Employees.Where(p => p.Is_Deleted == false).Select(p => new { p.Id, p.Name, p.Gender, p.Birthday, p.Address, p.Phone }).ToList();
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
                    var data = db.Employees.Where(p => ((p.Id).ToString().Contains(str_Search) || (p.Name).Contains(str_Search) || p.Birthday.ToString().Contains(str_Search) || p.Address.Contains(str_Search) || p.Phone.Contains(str_Search)) && p.Is_Deleted == false).ToList();
                    if (data.Count != 0)
                        return data;
                    else
                        return null;
                }
                catch(Exception e)
                {
                    return null;
                }
            }
        }
        public bool Add_DAL(string name, DateTime birthday, bool gender, string address, string phone)
        {
            using (SE_08 db = new SE_08())
            {
                try
                {
                    if (db.Employees.Where(p => p.Name == name && p.Birthday == birthday && p.Phone == phone && p.Is_Deleted == true).ToList().Count == 1)
                    {
                        Employee employee = db.Employees.Where(p => p.Name == name && p.Birthday == birthday && p.Phone == phone && p.Is_Deleted == true).SingleOrDefault();
                        employee.Is_Deleted = false;
                    }
                    else
                    {
                        var data = db.Employees.Add(new Employee { Name = name, Birthday = birthday, Gender = gender, Address = address, Phone = phone });
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
        public bool Delete_DAL(List<int> list_Del)
        {
            using (SE_08 db = new SE_08())
            {
                try
                {
                    foreach (int i in list_Del)
                    {
                        Employee employee = db.Employees.Single(p => p.Id == i);
                        employee.Is_Deleted = true;
                    }
                    db.SaveChanges();
                    return true;
                }
                catch(Exception e)
                {
                    return false;
                }
            }
        }
        public bool Update_DAL(int Id, string name_Update, DateTime birthday_Update, bool gender_Update, string address_Update, string phone_Update)
        {
            using (SE_08 db = new SE_08())
            {
                try
                {
                    Employee employee = db.Employees.SingleOrDefault(p => p.Id == Id);
                    employee.Name = name_Update;
                    employee.Birthday = birthday_Update;
                    employee.Gender = gender_Update;
                    employee.Address = address_Update;
                    employee.Phone = phone_Update;
                    db.SaveChanges();
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }

        public Employee GetEmployee(int Id_Employee)
        {
            using (SE_08 db = new SE_08())
            {
                try
                {
                    Employee em = db.Employees.Where(p => p.Id == Id_Employee).SingleOrDefault();
                    return em;
                }
                catch (Exception)
                {
                    return null;
                }
            }

        }
    }

}
