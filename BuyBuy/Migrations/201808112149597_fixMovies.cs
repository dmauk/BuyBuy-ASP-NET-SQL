namespace BuyBuy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Horror')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Comedy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Thriller')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Drama')");
        }
        
        public override void Down()
        {
        }
    }
}
