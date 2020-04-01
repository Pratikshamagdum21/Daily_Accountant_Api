namespace Daily_Accountant_Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddvirtualProp2 : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.VirtualProps");
        }
        
        public override void Down()
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
    }
}
