namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingBirthDateInCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "MyProperty", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "MyProperty");
        }
    }
}
