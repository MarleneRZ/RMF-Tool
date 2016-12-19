namespace Phase13.Web.DataContexts.RMFSystemMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeControl : DbMigration
    {
        
        public override void Up()
        {
            /*
            AddColumn("dbo.Controls", "ControlCode", c => c.String());
            AddColumn("dbo.Controls", "ControlPriority", c => c.String());
            AddColumn("dbo.Controls", "ControlBaselineLow", c => c.Boolean());
            AddColumn("dbo.Controls", "ControlBaselineModerate", c => c.Boolean());
            AddColumn("dbo.Controls", "ControlBaselineHigh", c => c.Boolean());
            AddColumn("dbo.Controls", "ControlDescription", c => c.String());
            */
        }
        
        public override void Down()
        {
            /*
            DropColumn("dbo.Controls", "ControlDescription");
            DropColumn("dbo.Controls", "ControlBaselineHigh");
            DropColumn("dbo.Controls", "ControlBaselineModerate");
            DropColumn("dbo.Controls", "ControlBaselineLow");
            DropColumn("dbo.Controls", "ControlPriority");
            DropColumn("dbo.Controls", "ControlCode");
        */
    }
    }
}
