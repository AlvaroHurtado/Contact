namespace Base_de_Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Tercera : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        firstName = c.String(nullable: false, maxLength: 30),
                        lastName = c.String(nullable: false, maxLength: 30),
                        birthday = c.String(nullable: false, maxLength: 10),
                        phoneNumber = c.String(maxLength: 20),
                        cellNumber = c.String(nullable: false, maxLength: 20),
                        photo = c.String(maxLength: 250),
                        email = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
