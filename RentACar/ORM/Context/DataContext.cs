using RentACar.ORM.Entity;
using System.Data.Entity;

namespace RentACar.ORM.Context
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
            Database.Connection.ConnectionString = "Server=.\\SQLEXPRESS;Database=RentACar;uid=sa;password=1";
        }

        // Migration Steps
        // package manager console
        // enable-migrations
        // add-migration migrationAdi
        // update-database

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Özel tablo isimlendirmesi
            modelBuilder.Entity<Araba>().ToTable("Arabalar");
            modelBuilder.Entity<Kiralama>().ToTable("Kiralamalar");
            modelBuilder.Entity<Yonetici>().ToTable("Yöneticiler");

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Araba> Arabalar { get; set; }
        public DbSet<Kiralama> Kiralamalar { get; set; }
        public DbSet<Yonetici> Yoneticiler { get; set; }
    }
}
