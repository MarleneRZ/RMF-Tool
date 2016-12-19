namespace Phase13.Web.DataContexts.RMFSystemMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            /*
            CreateTable(
                "dbo.RMFSystems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SystemName = c.String(nullable: false, maxLength: 255),
                        Confidentiality = c.Int(),
                        Integrity = c.Int(),
                        Availability = c.Int(),
                        AssessmentStartDate = c.DateTime(),
                        AssessmentEndDate = c.DateTime(),
                        AssessmentPriority = c.Int(nullable: false),
                        UserId = c.Int(),
                        StateId = c.Int(nullable: false),
                        State = c.Int(),
                        AssessmentStatus = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Contractor = c.Boolean(nullable: false),
                        UserType = c.Int(),
                        OrganizationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Organizations", t => t.OrganizationId, cascadeDelete: true)
                .Index(t => t.OrganizationId);
            
            CreateTable(
                "dbo.Organizations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrgName = c.String(),
                        OrgSymbol = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            */
        }
        
        public override void Down()
        {
            /*
            DropForeignKey("dbo.RMFSystems", "UserId", "dbo.Users");
            DropForeignKey("dbo.Users", "OrganizationId", "dbo.Organizations");
            DropIndex("dbo.Users", new[] { "OrganizationId" });
            DropIndex("dbo.RMFSystems", new[] { "UserId" });
            DropTable("dbo.Organizations");
            DropTable("dbo.Users");
            DropTable("dbo.RMFSystems");
            */
        }
    }
}
