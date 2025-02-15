using RentACar.ORM.Entity;
using System.Data.Entity;

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

            modelBuilder.Entity<Araba>().ToTable("Arabalar");
            modelBuilder.Entity<Kiralama>().ToTable("Kiralamalar");
            modelBuilder.Entity<Yonetici>().ToTable("Yoneticiler");
        }


        public DbSet<Araba> Arabalar { get; set; }
        public DbSet<Kiralama> Kiralamalar { get; set; }
        public DbSet<Yonetici> Yoneticiler { get; set; }
    }
}
