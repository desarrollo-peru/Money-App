namespace MoneyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addBalance_toUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "balance", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "balance");
        }
    }
}
