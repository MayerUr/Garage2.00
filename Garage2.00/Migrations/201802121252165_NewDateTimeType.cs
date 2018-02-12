namespace Garage2._00.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewDateTimeType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Vehicles", "TimestampIn", c => c.DateTime());
            AlterColumn("dbo.Vehicles", "TimestampOut", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vehicles", "TimestampOut", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Vehicles", "TimestampIn", c => c.DateTime(nullable: false));
        }
    }
}
