namespace RentACar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RentACarMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Arabas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Plaka = c.String(nullable: false),
                        Marka = c.String(nullable: false),
                        Model = c.String(nullable: false),
                        AracTipi = c.String(nullable: false),
                        Vites = c.String(nullable: false),
                        YakitTipi = c.String(nullable: false),
                        ImageUrl = c.String(),
                        Fiyat = c.Double(nullable: false),
                        AddDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        AktifMi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Kiralamas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ArabaID = c.Int(nullable: false),
                        YoneticiID = c.Int(nullable: false),
                        AlisTarihi = c.DateTime(nullable: false),
                        TeslimTarihi = c.DateTime(nullable: false),
                        KiralamaSuresi = c.DateTime(),
                        FaturaTutari = c.Double(nullable: false),
                        AddDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        AktifMi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Arabas", t => t.ArabaID, cascadeDelete: true)
                .ForeignKey("dbo.Yoneticis", t => t.YoneticiID, cascadeDelete: true)
                .Index(t => t.ArabaID)
                .Index(t => t.YoneticiID);
            
            CreateTable(
                "dbo.Yoneticis",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Adi = c.String(nullable: false),
                        Soyadi = c.String(nullable: false),
                        TC = c.String(nullable: false),
                        EhliyetNo = c.String(nullable: false),
                        Telefon = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Adres = c.String(nullable: false),
                        Sifre = c.String(nullable: false),
                        AddDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        AktifMi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Kiralamas", "YoneticiID", "dbo.Yoneticis");
            DropForeignKey("dbo.Kiralamas", "ArabaID", "dbo.Arabas");
            DropIndex("dbo.Kiralamas", new[] { "YoneticiID" });
            DropIndex("dbo.Kiralamas", new[] { "ArabaID" });
            DropTable("dbo.Yoneticis");
            DropTable("dbo.Kiralamas");
            DropTable("dbo.Arabas");
        }
    }
}
