namespace Daily_Accountant_Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeRegisterName : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Registers", newName: "Users");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Users", newName: "Registers");
        }
    }
}
