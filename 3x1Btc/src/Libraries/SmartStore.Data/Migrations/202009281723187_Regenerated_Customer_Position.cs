namespace SmartStore.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Regenerated_Customer_Position : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customer", "Position", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customer", "Position");
        }
    }
}
