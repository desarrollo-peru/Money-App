namespace MoneyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addBudgetTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Budgets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        quantity = c.Double(nullable: false),
                        frequency = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Users", "budget_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Users", "budget_Id");
            AddForeignKey("dbo.Users", "budget_Id", "dbo.Budgets", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "budget_Id", "dbo.Budgets");
            DropIndex("dbo.Users", new[] { "budget_Id" });
            DropColumn("dbo.Users", "budget_Id");
            DropTable("dbo.Budgets");
        }
    }
}
