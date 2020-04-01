namespace Daily_Accountant_Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedataExpenses : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ExpensesDetails", "ExpensesName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ExpensesDetails", "ExpensesName", c => c.String());
        }
    }
}
