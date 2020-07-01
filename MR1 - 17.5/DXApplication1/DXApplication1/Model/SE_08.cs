
using DXApplication1.DTO;
using System;
using System.Data.Entity;
using System.Linq;


namespace DXApplication1.DAL
{
 
    public class SE_08 : DbContext
    {
        // Your context has been configured to use a 'SE_08' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'DXApplication1.DAL.SE_08' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'SE_08' 
        // connection string in the application configuration file.
        public SE_08()
            : base("name=SE_08")
        {
            Database.SetInitializer<SE_08>(new CreateDB());
        }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Table> Tables { get; set; }
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<BillInfo> BillInfos  { get; set; }
        public virtual DbSet<TypeAccount> TypeAccounts { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }



        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}