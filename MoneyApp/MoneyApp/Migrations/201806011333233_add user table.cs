namespace MoneyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addusertable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        username = c.String(nullable: false),
                        password = c.String(nullable: false, maxLength: 15),
                        name = c.String(nullable: false),
                        lastname = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
