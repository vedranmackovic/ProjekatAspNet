namespace Projekat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRequiredToImeIPrezime : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.kupcis", "ImeIPrezime", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.kupcis", "ImeIPrezime", c => c.String());
        }
    }
}
