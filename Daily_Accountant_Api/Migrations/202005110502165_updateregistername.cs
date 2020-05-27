namespace Daily_Accountant_Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateregistername : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Registers", "Mail", c => c.String());
            AlterColumn("dbo.Registers", "UserName", c => c.String());
            AlterColumn("dbo.Registers", "Password", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Registers", "Password", c => c.String(nullable: false));
            AlterColumn("dbo.Registers", "UserName", c => c.String(nullable: false));
            AlterColumn("dbo.Registers", "Mail", c => c.String(nullable: false));
        }
    }
}
