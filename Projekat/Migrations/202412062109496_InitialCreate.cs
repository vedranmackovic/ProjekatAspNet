namespace Projekat.Migrations
{
    using Newtonsoft.Json;
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.kupcis",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Poruka = c.String(maxLength:300),
                        ImeIPrezime = c.String(maxLength:50, nullable:false),
                        Email = c.String(maxLength:30,nullable:false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.kupcis");
        }
    }
}
