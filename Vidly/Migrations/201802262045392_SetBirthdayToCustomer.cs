namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetBirthdayToCustomer : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthday = '12/31/2015' WHERE Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
