namespace Phase13.Web.DataContexts.RMFSystemMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPOAM : DbMigration
    {
        public override void Up()
        {
           /* CreateTable(
                "dbo.POAMItems",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        RMFSystemId = c.Int(nullable: false),
                        ControlId = c.Int(nullable: false),
                        WeaknessType = c.String(),
                        TargetDate = c.DateTime(nullable: false),
                        Responsible = c.String(),
                        FundingResource = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SchedCompletionDate = c.DateTime(nullable: false),
                        Milestone = c.String(),
                        SourceOfWeakness = c.String(),
                        Comments = c.String(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Controls", t => t.ControlId, cascadeDelete: true)
                .ForeignKey("dbo.RMFSystems", t => t.RMFSystemId, cascadeDelete: true)
                .Index(t => t.RMFSystemId)
                .Index(t => t.ControlId);

            CreateTable(
                "dbo.POAMs",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    LastUpdated = c.DateTime(nullable: false),
                    AuthorizationStatus = c.String(),
                    POAMItemId = c.Int(nullable: false),
                    //   RMFSystemId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
               .ForeignKey("dbo.POAMItems", t => t.POAMItemId, cascadeDelete: true)
                //  .ForeignKey("dbo.RMFSystems", t => t.RMFSystemId, cascadeDelete: true)
                .Index(t => t.POAMItemId);
               // .Index(t => t.RMFSystemId);
            */
        }
        
        public override void Down()
        {
            /*
          //  DropForeignKey("dbo.POAMs", "RMFSystemId", "dbo.RMFSystems");
            DropForeignKey("dbo.POAMs", "POAMItemId", "dbo.POAMItems");
            DropForeignKey("dbo.POAMItems", "RMFSystemId", "dbo.RMFSystems");
            DropForeignKey("dbo.POAMItems", "ControlId", "dbo.Controls");
          //  DropIndex("dbo.POAMs", new[] { "RMFSystemId" });
            DropIndex("dbo.POAMs", new[] { "POAMItemId" });
            DropIndex("dbo.POAMItems", new[] { "ControlId" });
            DropIndex("dbo.POAMItems", new[] { "RMFSystemId" });
            DropTable("dbo.POAMs");
            DropTable("dbo.POAMItems");
            */
    }
    }
}
