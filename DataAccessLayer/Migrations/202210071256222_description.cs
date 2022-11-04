namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class description : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "CategoryDescription", c => c.String(maxLength: 500));
            DropColumn("dbo.Categories", "CategoryName2");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "CategoryName2", c => c.String(maxLength: 30));
            DropColumn("dbo.Categories", "CategoryDescription");
        }
    }
}
