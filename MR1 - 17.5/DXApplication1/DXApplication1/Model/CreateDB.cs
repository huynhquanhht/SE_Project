using DXApplication1.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.DAL
{
    public class CreateDB : CreateDatabaseIfNotExists<SE_08>
    {
        protected override void Seed(SE_08 context)
        {
            #region Thêm loại
            context.Categories.Add(new Category
            {
                Id = 1,
                Name = "Món ăn nhẹ"
            });
            context.Categories.Add(new Category
            {
                Id = 2,
                Name = "Món khai vị"
            });
            context.Categories.Add(new Category
            {
                Id = 3,
                Name = "Món chính"
            });
            context.Categories.Add(new Category
            {
                Id = 4,
                Name = "Món tráng miệng"
            });
            context.Categories.Add(new Category
            {
                Id = 5,
                Name = "Thức uống"
            });
            #endregion
            #region Thêm món ăn nhẹ
            context.Items.Add(new Item
            {
                Id = 1,
                Name = "Khoai lang que nướng",
                Id_Category = 1,
                Price = 15000
            });
      
            context.Items.Add(new Item
            {
                Id = 2,
                Name = "Yaourt",
                Id_Category = 1,
                Price = 2000
            });
            context.Items.Add(new Item
            {
                Id = 3,
                Name = "Bánh quy kem",
                Id_Category = 1,
                Price = 9000
            });
            context.Items.Add(new Item
            {
                Id = 4,
                Name = "Snack bí đỏ",
                Id_Category = 1,
                Price = 10000
            });
            context.Items.Add(new Item
            {
                Id = 5,
                Name = "Nho khô",
                Id_Category = 1,
                Price = 150000
            });
            context.Items.Add(new Item
            {
                Id = 6,
                Name = "Bắp rang bơ",
                Id_Category = 1,
                Price = 20000
            });
            #endregion
            #region Thêm món khai vị
            context.Items.Add(new Item
            {
                Id = 7,
                Name = "Đậu trắng sốt cà chua",
                Id_Category = 2,
                Price = 35000
            });
            context.Items.Add(new Item
            {
                Id = 8,
                Name = "Nem cuốn thịt rán",
                Id_Category = 2,
                Price = 80000
            });
            context.Items.Add(new Item
            {
                Id = 9,
                Name = "Nộm đu đủ bò khô",
                Id_Category = 2,
                Price = 90000
            });
            context.Items.Add(new Item
            {
                Id = 10,
                Name = "Salad trứng của rong biển",
                Id_Category = 2,
                Price = 80000
            });
            context.Items.Add(new Item
            {
                Id = 11,
                Name = "Bắp bò bóp dấm",
                Id_Category = 2,
                Price = 90000
            });
            context.Items.Add(new Item
            {
                Id = 12,
                Name = "Nộm ngũ sắc",
                Id_Category = 2,
                Price = 90000
            });
            #endregion
            #region Thêm món chính
            context.Items.Add(new Item
            {
                Id = 13,
                Name = "Gà hấp hành",
                Id_Category = 3,
                Price = 370000
            });
            context.Items.Add(new Item
            {
                Id = 14,
                Name = "Vịt hầm thuốc bắc",
                Id_Category = 3,
                Price = 400000
            });
            context.Items.Add(new Item
            {
                Id = 15,
                Name = "Sườn non Bắc Kinh",
                Id_Category = 3,
                Price = 320000
            });
            context.Items.Add(new Item
            {
                Id = 16,
                Name = "Mì xào hải sản",
                Id_Category = 3,
                Price = 129000
            });
            context.Items.Add(new Item
            {
                Id = 17,
                Name = "Mì xào bò",
                Id_Category = 3,
                Price = 129000
            });
            #endregion
            #region Thêm món tráng miệng
            context.Items.Add(new Item
            {
                Id = 18,
                Name = "Chè khúc bạch",
                Id_Category = 4,
                Price = 25000
            });
            context.Items.Add(new Item
            {
                Id = 19,
                Name = "Caramel trứng gà ta",
                Id_Category = 4,
                Price = 20000
            });
            context.Items.Add(new Item
            {
                Id = 20,
                Name = "Panacota dâu tây",
                Id_Category = 4,
                Price = 30000
            });
            context.Items.Add(new Item
            {
                Id = 21,
                Name = "Panacota xoài",
                Id_Category = 4,
                Price = 25000
            });
            context.Items.Add(new Item
            {
                Id = 22,
                Name = "Rau câu Flan",
                Id_Category = 4,
                Price = 25000
            });
            #endregion
            #region Thêm thức uống
            context.Items.Add(new Item
            {
                Id = 23,
                Name = "Pepsi",
                Id_Category = 5,
                Price = 15000
            });
            context.Items.Add(new Item
            {
                Id = 24,
                Name = "7Up",
                Id_Category = 5,
                Price = 15000
            });
            context.Items.Add(new Item
            {
                Id = 25,
                Name = "Trà Lipton",
                Id_Category = 5,
                Price = 15000
            });
            context.Items.Add(new Item
            {
                Id = 26,
                Name = "Aquafina",
                Id_Category = 5,
                Price = 15000
            });
            context.Items.Add(new Item
            {
                Id = 27,
                Name = "Sữa ngô",
                Id_Category = 5,
                Price = 15000
            });
            #endregion
            #region Thêm bàn ăn
            context.Tables.Add(new Table
            {
                Id = 1,
                Name = "Bàn 1"
            });
            context.Tables.Add(new Table
            {
                Id = 2,
                Name = "Bàn 2"
            });
            context.Tables.Add(new Table
            {
                Id = 3,
                Name = "Bàn 3"
            });
            context.Tables.Add(new Table
            {
                Id = 4,
                Name = "Bàn 4"
            });
            context.Tables.Add(new Table
            {
                Id = 5,
                Name = "Bàn 5"
            });
            context.Tables.Add(new Table
            {
                Id = 6,
                Name = "Bàn 6"
            });
            context.Tables.Add(new Table
            {
                Id = 7,
                Name = "Bàn 7"
            });
            context.Tables.Add(new Table
            {
                Id = 8,
                Name = "Bàn 8"
            });
            context.Tables.Add(new Table
            {
                Id = 9,
                Name = "Bàn 9"
            });
            context.Tables.Add(new Table
            {
                Id = 10,
                Name = "Bàn 10"
            });
            context.Tables.Add(new Table
            {
                Id = 11,
                Name = "Bàn 11"
            });
            context.Tables.Add(new Table
            {
                Id = 12,
                Name = "Bàn 12"
            });
            #endregion
            #region Thêm hóa đơn
            context.Bills.Add(new Bill
            {
                Id = 1,
                Id_Table = 3,
                Date_Order = Convert.ToDateTime("2020-04-12"),
                Date_Pay = Convert.ToDateTime("2020-04-12"),
                Status = true,
                Id_Employee = 3
            });
            context.Bills.Add(new Bill
            {
                Id = 2,
                Id_Table = 7,
                Date_Order = Convert.ToDateTime("2020-04-14"),
                Date_Pay = Convert.ToDateTime("2020-04-14"),
                Status = true,
                Id_Employee = 3
            });
            context.Bills.Add(new Bill
            {
                Id = 3,
                Id_Table = 9,
                Date_Order = Convert.ToDateTime("2020-04-15"),
                Date_Pay = Convert.ToDateTime("2020-04-15"),
                Status = true,
                Id_Employee = 3
            });
            context.Bills.Add(new Bill
            {
                Id = 4,
                Id_Table = 8,
                Date_Order = Convert.ToDateTime("2020-04-16"),
                Date_Pay = Convert.ToDateTime("2020-04-16"),
                Status = true,
                Id_Employee = 3
            });
            context.Bills.Add(new Bill
            {
                Id = 5,
                Id_Table = 2,
                Date_Order = Convert.ToDateTime("2020-04-17"),
                Date_Pay = Convert.ToDateTime("2020-04-17"),
                Status = true,
                Id_Employee = 3
            });
            #endregion
            #region Thêm thông tin hóa đơn
            #endregion
            #region Thêm loại tài khoản
            context.TypeAccounts.Add(new TypeAccount
            {
                Id = 1,
                Name = "Admin"
            });
            context.TypeAccounts.Add(new TypeAccount
            {
                Id = 2,
                Name = "Mods"
            });
            context.TypeAccounts.Add(new TypeAccount
            {
                Id = 3,
                Name = "User"
            });
            #endregion
            #region Thêm tài khoản
            context.Accounts.Add(new Account
            {
                Id = 1,
                Username = "Admin",
                Password = "1",
                Id_Employee = 1,
                
                Id_Type = 1
            });
            context.Accounts.Add(new Account
            {
                Id = 2,
                Username = "Mods",
                Password = "2",
                Id_Employee = 2,
                Id_Type = 2
            });
            context.Accounts.Add(new Account
            {
                Id = 3,
                Username = "User",
                Password = "3",
                Id_Employee = 3,
                Id_Type = 3
            });
            #endregion
            #region Thêm nhân viên
            context.Employees.Add(new Employee
            {
                Id = 1,
                Name = "Nguyễn Văn A",
                Gender = true,
                Birthday = Convert.ToDateTime("1998-02-05"),
                Address = "Đà Nẵng",
                Phone = "0905050001",


            });
            context.Employees.Add(new Employee
            {
                Id = 2,
                Name = "Nguyễn Văn B",
                Gender = true,
                Birthday = Convert.ToDateTime("2001-09-03"),
                Address = "Quảng Nam",
                Phone = "0905050002",
 

            });
            context.Employees.Add(new Employee
            {
                Id = 3,
                Name = "Nguyễn Văn C",
                Gender = true,
                Birthday = Convert.ToDateTime("2000-06-01"),
                Address = "Huế",
                Phone = "0905050003",
          
    
            });
            #endregion
            context.SaveChanges();
        }
    }
}
