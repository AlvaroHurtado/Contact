namespace Base_de_Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Segunda : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Advisers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 30),
                        LastName = c.String(nullable: false, maxLength: 30),
                        PhoneNumber = c.String(maxLength: 20),
                        CellphoneNumber = c.String(nullable: false, maxLength: 20),
                        Photo = c.String(maxLength: 250),
                        Email = c.String(nullable: false, maxLength: 30),
                        Department = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        Address = c.String(nullable: false, maxLength: 30),
                        PostalCode = c.String(maxLength: 20),
                        PhoneNumber = c.String(nullable: false, maxLength: 20),
                        Photo = c.String(maxLength: 250),
                        Email = c.String(nullable: false, maxLength: 30),
                        Website = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Companies");
            DropTable("dbo.Advisers");
        }
    }
}
