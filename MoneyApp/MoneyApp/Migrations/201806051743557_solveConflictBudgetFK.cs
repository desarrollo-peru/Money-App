namespace MoneyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class solveConflictBudgetFK : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Users", "budget_Id", "dbo.Budgets");
            DropIndex("dbo.Users", new[] { "budget_Id" });
            AlterColumn("dbo.Users", "budget_Id", c => c.Int());
            CreateIndex("dbo.Users", "budget_Id");
            AddForeignKey("dbo.Users", "budget_Id", "dbo.Budgets", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "budget_Id", "dbo.Budgets");
            DropIndex("dbo.Users", new[] { "budget_Id" });
            AlterColumn("dbo.Users", "budget_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Users", "budget_Id");
            AddForeignKey("dbo.Users", "budget_Id", "dbo.Budgets", "Id", cascadeDelete: true);
        }
    }
}
