using DXApplication1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.DAL
{
    public class BUS_Account
    {
        private BUS_Account() { }
        private static BUS_Account _Instance;
        public static BUS_Account Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BUS_Account();
                }
                return _Instance;
            }
            private set => _Instance = value;
        }
        public object Show_DAL(int Id_Type)
        {
            using (SE_08 db = new SE_08())
            {
                try
                {
                    if (Id_Type == 0)
                    {
                        var data = db.Accounts.Select(p => new { Id = p.Id, Name = p.Employee.Name, p.Employee.Phone, p.Username, p.Password, NameType = p.TypeAccount.Name }).ToList();
                        return data;

                    }
                    else
                    {
                        var data = db.Accounts.Where(p => p.Id_Type == Id_Type).Select(p => new { Id = p.Id, Name = p.Employee.Name, p.Employee.Phone, p.Username, p.Password, NameType = p.TypeAccount.Name }).ToList();
                        return data;
                    }
                }
                catch(Exception)
                {
                    return null;
                }
            }
        }
        public IEnumerable<dynamic> GetTypeAccount_DAL()
        {
            using (SE_08 db = new SE_08())
            {
                try
                {
                    IEnumerable<dynamic> list_TypeAccount = db.TypeAccounts.Select(p => new { p.Id, p.Name }).ToList();
                    return list_TypeAccount;
                }
                catch(Exception)
                {
                    return null;
                }
            }

        }
        public bool Add_DAL(string name, string phone, string username, string password, int Id_Type)
        {
            using (SE_08 db = new SE_08())
            {
                try
                {
                    byte[] temp = ASCIIEncoding.ASCII.GetBytes(password);
                    byte[] hashData = new MD5CryptoServiceProvider().ComputeHash(temp);
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < hashData.Length; i++)
                    {
                        sb.Append(hashData[i].ToString("x2"));

                    }
                    
                    Employee em = db.Employees.Where(p => p.Name == name && p.Phone == phone).SingleOrDefault();
                    var data = db.Accounts.Add(new Account { Username = username, Password = sb.ToString(), Id_Employee = em.Id, Id_Type = Id_Type });
                    db.SaveChanges();
                    return true;

                }
                catch (Exception e)
                {
                    return false;
                }

            }
        }
        public object Search_DAL(int Id_Type, string str_Search)
        {

            using (SE_08 db = new SE_08())
            {
                try
                {
                    if (str_Search == "")
                    {
                        if (Id_Type == 0)
                        {
                            var data = db.Accounts.Select(p => new { Id = p.Id, Name = p.Employee.Name, p.Employee.Phone, p.Username, p.Password, NameType = p.TypeAccount.Name }).ToList();
                            return data;
                        }
                        else
                        {
                            var data = db.Accounts.Where(p => p.Id_Type == Id_Type).Select(p => new { Id = p.Id, Name = p.Employee.Name, p.Employee.Phone, p.Username, p.Password, NameType = p.TypeAccount.Name }).ToList();
                            return data;
                        }
                    }
                    else
                    {
                        if (Id_Type == 0)
                        {
                            var data = db.Accounts.Where(p => ((p.Id).ToString().Contains(str_Search) || (p.Employee.Name).Contains(str_Search)) || p.Employee.Phone.Contains(str_Search) || p.Username.Contains(str_Search) || p.TypeAccount.Name.Contains(str_Search))
                                              .Select(p => new { Id = p.Id, Name = p.Employee.Name, p.Employee.Phone, p.Username, p.Password, NameType = p.TypeAccount.Name }).ToList();
                            if (data.Count == 0)
                                return null;
                            else
                                return data;
                        }
                        else
                        {

                            var data = db.Accounts.Where(p => p.Id_Type == Id_Type && (((p.Id).ToString().Contains(str_Search) || (p.Employee.Name).Contains(str_Search)) || p.Employee.Phone.Contains(str_Search) || p.Username.Contains(str_Search) || p.TypeAccount.Name.Contains(str_Search)))
                                              .Select(p => new { Id = p.Id, Name = p.Employee.Name, p.Employee.Phone, p.Username, p.Password, NameType = p.TypeAccount.Name }).ToList();
                            if (data.Count == 0)
                                return null;
                            else
                                return data;
                        }
                    }
                }
                catch(Exception)
                {
                    return null;
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
                        Account account = db.Accounts.Single(p => p.Id == i);
                        db.Accounts.Remove(account);
                    }
                    db.SaveChanges();
                    return true;
                }
                catch(Exception)
                {
                    return false;
                }
            }
        }
        public bool Update_DAL(int Id, string name, string phone, string username, string password, int Id_Type)
        {
            using (SE_08 db = new SE_08())
            {
                try
                {
                    Account account = db.Accounts.SingleOrDefault(p => p.Id == Id && p.Employee.Phone == phone);
                    account.Id = account.Id;
                    account.Username = username;
                    account.Password = password;
                    account.Id_Type = Id_Type;
      
                    db.SaveChanges();
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }
        public Account GetAccountByUsername(string username)
        {
            using (SE_08 db = new SE_08())
            {
                try
                {
                    Account account = db.Accounts.Where(p => p.Username == username).SingleOrDefault();
                    return account;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
        public Account Login(string username, string password)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(password);
            byte[] hashData = new MD5CryptoServiceProvider().ComputeHash(temp);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashData.Length; i++)
            {
                sb.Append(hashData[i].ToString("x2"));

            }
            Account account =  GetAccountByUsername(username);
            if (account != null &&sb.ToString() == account.Password)
            {
                return account;
            }
            else
            {
                return null;
            }
        }
        public Account GetAccountByIdEmployee(int Id_Em)
        {
            using (SE_08 db = new SE_08())
            {
                try
                {
                    Account account = db.Accounts.Where(p => p.Id_Employee == Id_Em).SingleOrDefault();
                    return account;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
        public bool ChangePassword(string newpass, int Id_Em)
        {
            using (SE_08 db = new SE_08())
            {
                try
                {
                    Account account = db.Accounts.SingleOrDefault(p => p.Id_Employee == Id_Em);
                    account.Password = newpass;
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
