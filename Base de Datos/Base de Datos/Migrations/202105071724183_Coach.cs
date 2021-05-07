﻿namespace Base_de_Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Coach : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Coaches",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 30),
                        LastName = c.String(nullable: false, maxLength: 30),
                        CellNumber = c.String(nullable: false, maxLength: 20),
                        Photo = c.String(maxLength: 250),
                        Email = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Coaches");
        }
    }
}