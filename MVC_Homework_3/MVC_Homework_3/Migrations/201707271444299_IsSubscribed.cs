namespace MVC_Homework_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IsSubscribed : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "IsSubscribed", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Events", "IsSubscribed");
        }
    }
}
