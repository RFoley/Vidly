namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipNameNotNull : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name='NOT SET' WHERE Name IS NULL");
            Sql("ALTER TABLE MembershipTypes ALTER COLUMN Name NVARCHAR(MAX) NOT NULL");
        }
        
        public override void Down()
        {
        }
    }
}
