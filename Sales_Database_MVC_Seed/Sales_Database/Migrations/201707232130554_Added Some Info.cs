namespace Sales_Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedSomeInfo : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Sales", "Date", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Sales", "Date", c => c.DateTime(nullable: false));
        }
    }
}
