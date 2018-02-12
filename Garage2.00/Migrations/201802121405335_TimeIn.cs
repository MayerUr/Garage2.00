namespace Garage2._00.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TimeIn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vehicles", "TimestampIn", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Vehicles", "TimestampIn");
        }
    }
}
