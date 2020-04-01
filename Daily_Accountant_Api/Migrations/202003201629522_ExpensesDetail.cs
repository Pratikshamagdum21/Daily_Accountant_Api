namespace Daily_Accountant_Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ExpensesDetail : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ExpensesDetails",
                c => new
                    {
                        Expenses_Id = c.Int(nullable: false, identity: true),
                        registerId = c.Int(nullable: false),
                        Category = c.String(),
                        date = c.DateTime(nullable: false),
                        NOte = c.String(),
                        Amount = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Expenses_Id)
                .ForeignKey("dbo.Registers", t => t.registerId, cascadeDelete: true)
                .Index(t => t.registerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ExpensesDetails", "registerId", "dbo.Registers");
            DropIndex("dbo.ExpensesDetails", new[] { "registerId" });
            DropTable("dbo.ExpensesDetails");
        }
    }
}
