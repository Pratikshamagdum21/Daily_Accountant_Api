namespace Daily_Accountant_Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddvirtualProp : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.VirtualProps",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RegisterId = c.Int(nullable: false),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.VirtualProps");
        }
    }
}
