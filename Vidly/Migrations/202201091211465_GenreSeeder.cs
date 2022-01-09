namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GenreSeeder : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Name) VALUES ('Comdey')");
            Sql("INSERT INTO Genres (Name) VALUES ('Action')");
            Sql("INSERT INTO Genres (Name) VALUES ('Fantasy')");
            Sql("INSERT INTO Genres (Name) VALUES ('Musical')");
            Sql("INSERT INTO Genres (Name) VALUES ('Dance')");
            Sql("INSERT INTO Genres (Name) VALUES ('Adventure')");
        }
        
        public override void Down()
        {
        }
    }
}
