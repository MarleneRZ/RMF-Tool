namespace Phase13.Web.DataContexts.RMFSystemMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSAP2 : DbMigration
    {
        public override void Up()
        {
           /* CreateTable(
                "dbo.SAPs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SAPStatus = c.Int(),
                        FileTemplateId = c.Int(nullable: false),
                        RMFSystemsId = c.Int(nullable: false),
                        RMFSystem_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FileTemplates", t => t.FileTemplateId, cascadeDelete: true)
                .ForeignKey("dbo.RMFSystems", t => t.RMFSystem_Id)
                .Index(t => t.FileTemplateId)
                .Index(t => t.RMFSystem_Id);
            
            CreateTable(
                "dbo.FileTemplates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FileName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            */
        }
        
        public override void Down()
        {
            /*
            DropForeignKey("dbo.SAPs", "RMFSystem_Id", "dbo.RMFSystems");
            DropForeignKey("dbo.SAPs", "FileTemplateId", "dbo.FileTemplates");
            DropIndex("dbo.SAPs", new[] { "RMFSystem_Id" });
            DropIndex("dbo.SAPs", new[] { "FileTemplateId" });
            DropTable("dbo.FileTemplates");
            DropTable("dbo.SAPs");
            */
        }
    }
}
