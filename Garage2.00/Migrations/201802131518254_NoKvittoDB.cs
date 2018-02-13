namespace Garage2._00.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NoKvittoDB : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Kvittoes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Kvittoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
