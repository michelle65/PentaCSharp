namespace MVC_Homework_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedDateAndTIme : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Comments", "Date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Comments", "Date", c => c.String());
        }
    }
}
