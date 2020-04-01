namespace Daily_Accountant_Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Category_WalletDetails : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WalletDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WalletName = c.String(),
                        Amount = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.ExpensesDetails", "CategoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.ExpensesDetails", "CategoryId");
            AddForeignKey("dbo.ExpensesDetails", "CategoryId", "dbo.Categories", "Id", cascadeDelete: true);
            DropColumn("dbo.ExpensesDetails", "Category");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ExpensesDetails", "Category", c => c.String());
            DropForeignKey("dbo.ExpensesDetails", "CategoryId", "dbo.Categories");
            DropIndex("dbo.ExpensesDetails", new[] { "CategoryId" });
            DropColumn("dbo.ExpensesDetails", "CategoryId");
            DropTable("dbo.WalletDetails");
            DropTable("dbo.Categories");
        }
    }
}
