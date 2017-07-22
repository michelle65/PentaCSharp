namespace MVC_Homework_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migListController : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "AppliactionUserId", c => c.String());
            AddColumn("dbo.Events", "ApplicationUser_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Events", "ApplicationUser_Id");
            AddForeignKey("dbo.Events", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Events", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Events", new[] { "ApplicationUser_Id" });
            DropColumn("dbo.Events", "ApplicationUser_Id");
            DropColumn("dbo.Events", "AppliactionUserId");
        }
    }
}
