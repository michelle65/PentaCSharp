namespace MVC_Homework_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedanewField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "Image", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Events", "Image");
        }
    }
}
