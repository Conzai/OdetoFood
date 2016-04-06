namespace OdeToFoodConnor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Restaurants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        City = c.String(),
                        Country = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ResturantReviews",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Rating = c.Int(nullable: false),
                        Body = c.String(),
                        ResturantId = c.Int(nullable: false),
                        Restaurant_Id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Restaurants", t => t.Restaurant_Id)
                .Index(t => t.Restaurant_Id);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.ResturantReviews", new[] { "Restaurant_Id" });
            DropForeignKey("dbo.ResturantReviews", "Restaurant_Id", "dbo.Restaurants");
            DropTable("dbo.ResturantReviews");
            DropTable("dbo.Restaurants");
        }
    }
}
