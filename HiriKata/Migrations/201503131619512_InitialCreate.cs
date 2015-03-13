namespace HiriKata.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Words",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        En = c.String(),
                        Jp = c.String(),
                        Section = c.String(),
                        Category = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Words");
        }
    }
}
