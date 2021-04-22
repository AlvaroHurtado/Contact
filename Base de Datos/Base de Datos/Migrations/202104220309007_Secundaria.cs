namespace Base_de_Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Secundaria : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contacts", "FirstName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Contacts", "LastName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Contacts", "PhoneNumber", c => c.String(maxLength: 20));
            AlterColumn("dbo.Contacts", "CellphoneNumber", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Contacts", "Photo", c => c.String(maxLength: 250));
            AlterColumn("dbo.Contacts", "Email", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Contacts", "Department", c => c.String(nullable: false, maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contacts", "Department", c => c.String());
            AlterColumn("dbo.Contacts", "Email", c => c.String());
            AlterColumn("dbo.Contacts", "Photo", c => c.String());
            AlterColumn("dbo.Contacts", "CellphoneNumber", c => c.String());
            AlterColumn("dbo.Contacts", "PhoneNumber", c => c.String());
            AlterColumn("dbo.Contacts", "LastName", c => c.String());
            AlterColumn("dbo.Contacts", "FirstName", c => c.String());
        }
    }
}
