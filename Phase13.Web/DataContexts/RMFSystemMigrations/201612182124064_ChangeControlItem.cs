namespace Phase13.Web.DataContexts.RMFSystemMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeControlItem : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ControlItems", "ControlItemCode", c => c.String());
            AddColumn("dbo.ControlItems", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ControlItems", "Description");
            DropColumn("dbo.ControlItems", "ControlItemCode");
        }
    }
}
