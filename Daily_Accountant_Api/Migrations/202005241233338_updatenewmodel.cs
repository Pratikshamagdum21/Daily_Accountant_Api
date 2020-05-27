namespace Daily_Accountant_Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatenewmodel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BorrowedMoneys",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LenderName = c.String(),
                        Amount = c.Long(nullable: false),
                        Note = c.String(),
                        registerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Registers", t => t.registerId, cascadeDelete: false)
                .Index(t => t.registerId);
            
            CreateTable(
                "dbo.Budgets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BudgetName = c.String(),
                        Amount = c.Long(nullable: false),
                        registerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Registers", t => t.registerId, cascadeDelete: false)
                .Index(t => t.registerId);
            
            CreateTable(
                "dbo.MoneyLenders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BorrowerName = c.String(),
                        Amount = c.Long(nullable: false),
                        Note = c.String(),
                        registerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Registers", t => t.registerId, cascadeDelete: false)
                .Index(t => t.registerId);
            
            AlterColumn("dbo.Registers", "Mail", c => c.String(nullable: false));
            AlterColumn("dbo.Registers", "UserName", c => c.String(nullable: false));
            AlterColumn("dbo.Registers", "Password", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MoneyLenders", "registerId", "dbo.Registers");
            DropForeignKey("dbo.Budgets", "registerId", "dbo.Registers");
            DropForeignKey("dbo.BorrowedMoneys", "registerId", "dbo.Registers");
            DropIndex("dbo.MoneyLenders", new[] { "registerId" });
            DropIndex("dbo.Budgets", new[] { "registerId" });
            DropIndex("dbo.BorrowedMoneys", new[] { "registerId" });
            AlterColumn("dbo.Registers", "Password", c => c.String());
            AlterColumn("dbo.Registers", "UserName", c => c.String());
            AlterColumn("dbo.Registers", "Mail", c => c.String());
            DropTable("dbo.MoneyLenders");
            DropTable("dbo.Budgets");
            DropTable("dbo.BorrowedMoneys");
        }
    }
}
