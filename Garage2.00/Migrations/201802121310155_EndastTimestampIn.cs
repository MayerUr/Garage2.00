namespace Garage2._00.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EndastTimestampIn : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Vehicles", "TimestampIn", c => c.DateTime(nullable: false));
            DropColumn("dbo.Vehicles", "TimestampOut");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Vehicles", "TimestampOut", c => c.DateTime());
            AlterColumn("dbo.Vehicles", "TimestampIn", c => c.DateTime());
        }
    }
}
