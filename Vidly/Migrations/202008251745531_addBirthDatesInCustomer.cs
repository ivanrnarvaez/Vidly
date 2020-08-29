namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addBirthDatesInCustomer : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET BirthDate= CAST('19800101' AS DATETIME) WHERE id=1");
            
        }
        
        public override void Down()
        {
        }
    }
}
