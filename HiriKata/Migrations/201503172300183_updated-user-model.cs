namespace HiriKata.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedusermodel : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Users", "passwordhash");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "passwordhash", c => c.String());
        }
    }
}
