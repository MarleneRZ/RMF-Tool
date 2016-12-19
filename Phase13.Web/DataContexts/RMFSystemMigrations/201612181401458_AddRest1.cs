namespace Phase13.Web.DataContexts.RMFSystemMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRest1 : DbMigration
    {
        public override void Up()
        {
            /*
            CreateTable(
                "dbo.Artifacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RMFSystemId = c.Int(),
                        ArtifactName = c.String(),
                        Description = c.String(),
                        FileTemplateId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FileTemplates", t => t.FileTemplateId, cascadeDelete: true)
                .ForeignKey("dbo.RMFSystems", t => t.RMFSystemId)
                .Index(t => t.RMFSystemId)
                .Index(t => t.FileTemplateId);
            
            CreateTable(
                "dbo.SystemControls",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        RMFSystemId = c.Int(nullable: false),
                        ControlId = c.Int(nullable: false),
                        FindingResultDescription = c.String(),
                        FindingRecommendation = c.String(),
                        FindingStatus = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Controls", t => t.ControlId, cascadeDelete: true)
                .ForeignKey("dbo.RMFSystems", t => t.RMFSystemId, cascadeDelete: true)
                .Index(t => t.RMFSystemId)
                .Index(t => t.ControlId);
            
            CreateTable(
                "dbo.Controls",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ControlName = c.String(),
                        FamilyControlId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FamilyControls", t => t.FamilyControlId, cascadeDelete: true)
                .Index(t => t.FamilyControlId);
            
            CreateTable(
                "dbo.ControlItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ControlId = c.Int(nullable: false),
                        AssessmentObjective = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Controls", t => t.ControlId, cascadeDelete: true)
                .Index(t => t.ControlId);
            
            CreateTable(
                "dbo.FamilyControls",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FamilyName = c.String(),
                        FamilyDescription = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Packages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ArtifactId = c.Int(),
                        RMFSystemId = c.Int(),
                        submitted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Artifacts", t => t.ArtifactId)
                .ForeignKey("dbo.RMFSystems", t => t.RMFSystemId)
                .Index(t => t.ArtifactId)
                .Index(t => t.RMFSystemId);
            */
        }
        
        public override void Down()
        {
            /*
            DropForeignKey("dbo.Packages", "RMFSystemId", "dbo.RMFSystems");
            DropForeignKey("dbo.Packages", "ArtifactId", "dbo.Artifacts");
            DropForeignKey("dbo.Artifacts", "RMFSystemId", "dbo.RMFSystems");
            DropForeignKey("dbo.SystemControls", "RMFSystemId", "dbo.RMFSystems");
            DropForeignKey("dbo.SystemControls", "ControlId", "dbo.Controls");
            DropForeignKey("dbo.Controls", "FamilyControlId", "dbo.FamilyControls");
            DropForeignKey("dbo.ControlItems", "ControlId", "dbo.Controls");
            DropForeignKey("dbo.Artifacts", "FileTemplateId", "dbo.FileTemplates");
            DropIndex("dbo.Packages", new[] { "RMFSystemId" });
            DropIndex("dbo.Packages", new[] { "ArtifactId" });
            DropIndex("dbo.ControlItems", new[] { "ControlId" });
            DropIndex("dbo.Controls", new[] { "FamilyControlId" });
            DropIndex("dbo.SystemControls", new[] { "ControlId" });
            DropIndex("dbo.SystemControls", new[] { "RMFSystemId" });
            DropIndex("dbo.Artifacts", new[] { "FileTemplateId" });
            DropIndex("dbo.Artifacts", new[] { "RMFSystemId" });
            DropTable("dbo.Packages");
            DropTable("dbo.FamilyControls");
            DropTable("dbo.ControlItems");
            DropTable("dbo.Controls");
            DropTable("dbo.SystemControls");
            DropTable("dbo.Artifacts");
        */}
    }
}
