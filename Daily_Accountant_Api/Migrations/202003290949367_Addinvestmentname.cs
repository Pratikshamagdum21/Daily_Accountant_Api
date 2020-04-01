namespace Daily_Accountant_Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addinvestmentname : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.InvestmentNameIds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Investment_Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.InvestmentDetails", "Investment_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.InvestmentDetails", "Investment_Id");
            AddForeignKey("dbo.InvestmentDetails", "Investment_Id", "dbo.InvestmentNameIds", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.InvestmentDetails", "Investment_Id", "dbo.InvestmentNameIds");
            DropIndex("dbo.InvestmentDetails", new[] { "Investment_Id" });
            DropColumn("dbo.InvestmentDetails", "Investment_Id");
            DropTable("dbo.InvestmentNameIds");
        }
    }
}
