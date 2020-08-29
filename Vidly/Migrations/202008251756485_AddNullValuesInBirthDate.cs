namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNullValuesInBirthDate : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET BirthDate= NULL WHERE id=2");
        }
        
        public override void Down()
        {
        }
    }
}
