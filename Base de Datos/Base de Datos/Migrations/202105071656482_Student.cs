namespace Base_de_Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Student : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "Birthday", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Birthday", c => c.String(nullable: false, maxLength: 10));
        }
    }
}
