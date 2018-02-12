namespace Garage2._00.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Input2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Vehicles", "RegistrationNumber", c => c.String(nullable: false, maxLength: 7));
            AlterColumn("dbo.Vehicles", "Color", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Vehicles", "Brand", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Vehicles", "Model", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vehicles", "Model", c => c.String());
            AlterColumn("dbo.Vehicles", "Brand", c => c.String());
            AlterColumn("dbo.Vehicles", "Color", c => c.String());
            AlterColumn("dbo.Vehicles", "RegistrationNumber", c => c.String());
        }
    }
}
