namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class populateGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[Genres](Name) VALUES('Comedy'),('Action'),('Family'),('Romance')");
        }

        public override void Down()
        {
        }
    }
}
