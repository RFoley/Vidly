namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WrongDataTypeLmao : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE Customers ALTER COLUMN BirthDate DATE");
        }
        
        public override void Down()
        {
        }
    }
}
