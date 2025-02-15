namespace RentACar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class customTableName : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Arabas", newName: "Arabalar");
            RenameTable(name: "dbo.Kiralamas", newName: "Kiralamalar");
            RenameTable(name: "dbo.Yoneticis", newName: "Yoneticiler");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Yoneticiler", newName: "Yoneticis");
            RenameTable(name: "dbo.Kiralamalar", newName: "Kiralamas");
            RenameTable(name: "dbo.Arabalar", newName: "Arabas");
        }
    }
}
