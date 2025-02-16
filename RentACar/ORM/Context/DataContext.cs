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

        // Migration Steps
        // package manager console
        // enable-migrations
        // add-migration migrationAdi
        // update-database

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //"s" takısı ekleme işlemi olmasın diye manuel belirliyoruz.
            //Sorum: PluralizingTableNameConvention kısmını yapamadım, using Entity ve using PluralizingTableNameConvention eklemiş olmama rağmen.
            modelBuilder.Entity<Araba>().ToTable("Arabalar");
            modelBuilder.Entity<Kiralama>().ToTable("Kiralamalar");

            modelBuilder.Entity<Kiralama>()
                //Kiralama işlemi bir arabaya ait.
                .HasRequired(k => k.Araba)
                //Bir arabanın birden fazla kiralama işlemi olabilir.
                .WithMany()
                .HasForeignKey(k => k.ArabaID)
                //Arabayı silsek de kiralama bilgileri silinmeyecek.
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Kiralama>()
                //Her kiralama işlemi bir yöneticiye ait olmalı.
                .HasRequired(y => y.Yonetici)
                //Bir yöneticinin birden fazla kiralama işlemi olabilir.
                .WithMany()
                .HasForeignKey(y => y.YoneticiID)
                //Yöneticiyi silsek de kiralama bilgileri silinmeyecek.
                .WillCascadeOnDelete(false);

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
