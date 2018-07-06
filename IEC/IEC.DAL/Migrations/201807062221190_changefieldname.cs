namespace IEC.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changefieldname : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.IdentityCards", "DateOfExpiry", c => c.DateTime(nullable: false));
            DropColumn("dbo.IdentityCards", "ExperationDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.IdentityCards", "ExperationDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.IdentityCards", "DateOfExpiry");
        }
    }
}
