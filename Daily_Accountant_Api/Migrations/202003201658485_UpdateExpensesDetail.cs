namespace Daily_Accountant_Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateExpensesDetail : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ExpensesDetails", "ExpensesName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ExpensesDetails", "ExpensesName");
        }
    }
}
