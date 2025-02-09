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

        // Migration Steps
        // package manager console
        // enable-migrations
        // add-migration migrationAdi
        // update-database

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Araba> Arabalar { get; set; }
        public DbSet<Kiralama> Kiralamalar { get; set; }
        public DbSet<Yonetici> Yoneticiler { get; set; }
    }
}
