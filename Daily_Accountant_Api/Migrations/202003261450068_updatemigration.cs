namespace Daily_Accountant_Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatemigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.InvestmentDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        registerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Registers", t => t.registerId, cascadeDelete: true)
                .Index(t => t.registerId);
            
            AddColumn("dbo.Categories", "registerId", c => c.Int(nullable: false));
            AddColumn("dbo.WalletDetails", "registerId", c => c.Int(nullable: false));
            CreateIndex("dbo.Categories", "registerId");
            CreateIndex("dbo.WalletDetails", "registerId");
            AddForeignKey("dbo.Categories", "registerId", "dbo.Registers", "Id", cascadeDelete: false);
            AddForeignKey("dbo.WalletDetails", "registerId", "dbo.Registers", "Id", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WalletDetails", "registerId", "dbo.Registers");
            DropForeignKey("dbo.InvestmentDetails", "registerId", "dbo.Registers");
            DropForeignKey("dbo.Categories", "registerId", "dbo.Registers");
            DropIndex("dbo.WalletDetails", new[] { "registerId" });
            DropIndex("dbo.InvestmentDetails", new[] { "registerId" });
            DropIndex("dbo.Categories", new[] { "registerId" });
            DropColumn("dbo.WalletDetails", "registerId");
            DropColumn("dbo.Categories", "registerId");
            DropTable("dbo.InvestmentDetails");
        }
    }
}
