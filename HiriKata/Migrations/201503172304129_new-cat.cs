namespace HiriKata.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newcat : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "passwordhash", c => c.String());
            AddColumn("dbo.Users", "CreatedAt", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "CreatedAt");
            DropColumn("dbo.Users", "passwordhash");
        }
    }
}
