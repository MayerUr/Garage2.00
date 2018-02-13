namespace Garage2._00.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DoIt : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kvittoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Kvittoes");
        }
    }
}
