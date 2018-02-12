namespace Garage2._00.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TimestampInTimestampOut : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vehicles", "TimestampIn", c => c.DateTime(nullable: false));
            AddColumn("dbo.Vehicles", "TimestampOut", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Vehicles", "TimestampOut");
            DropColumn("dbo.Vehicles", "TimestampIn");
        }
    }
}
