using RentACar.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.ORM.Context
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
            Database.Connection.ConnectionString = "Server=.;Database=RentACar;uid=sa;password=1";
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Arabalar> Arabalars { get; set; }
        public DbSet<Kiralama> Kiralamas { get; set; }
        public DbSet<Yoneticiler> Yoneticilers { get; set; }
    }
}
