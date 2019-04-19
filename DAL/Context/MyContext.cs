using DAL.Migrations;
using Entity;
using Entity.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    public class MyContext : DbContext
    {
        public MyContext() : base("MyContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MyContext, Configuration>("MyContext"));
        }


        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
    }
}
