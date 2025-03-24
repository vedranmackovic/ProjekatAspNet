namespace Projekat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRequiredToEmail : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.kupcis", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.kupcis", "Email", c => c.String());
        }
    }
}
