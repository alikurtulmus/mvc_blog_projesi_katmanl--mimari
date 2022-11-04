namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class authorjob : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Authors", "AuthorJob", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Authors", "AuthorJob");
        }
    }
}
