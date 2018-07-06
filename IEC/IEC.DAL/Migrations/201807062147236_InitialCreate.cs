namespace IEC.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleteDate = c.DateTime(),
                        LastUpdateDate = c.DateTime(),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.IdentityCards",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        PersonalNumber = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        IssueDate = c.DateTime(nullable: false),
                        ExperationDate = c.DateTime(nullable: false),
                        CardNumber = c.String(),
                        Organization = c.String(),
                        CountryID = c.Int(nullable: false),
                        GenderID = c.Int(nullable: false),
                        CityID = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleteDate = c.DateTime(),
                        LastUpdateDate = c.DateTime(),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Cities", t => t.CityID, cascadeDelete: true)
                .ForeignKey("dbo.Countries", t => t.CountryID, cascadeDelete: true)
                .ForeignKey("dbo.Genders", t => t.GenderID, cascadeDelete: true)
                .Index(t => t.CountryID)
                .Index(t => t.GenderID)
                .Index(t => t.CityID);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ShortName = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleteDate = c.DateTime(),
                        LastUpdateDate = c.DateTime(),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleteDate = c.DateTime(),
                        LastUpdateDate = c.DateTime(),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.IdentityCards", "GenderID", "dbo.Genders");
            DropForeignKey("dbo.IdentityCards", "CountryID", "dbo.Countries");
            DropForeignKey("dbo.IdentityCards", "CityID", "dbo.Cities");
            DropIndex("dbo.IdentityCards", new[] { "CityID" });
            DropIndex("dbo.IdentityCards", new[] { "GenderID" });
            DropIndex("dbo.IdentityCards", new[] { "CountryID" });
            DropTable("dbo.Genders");
            DropTable("dbo.Countries");
            DropTable("dbo.IdentityCards");
            DropTable("dbo.Cities");
        }
    }
}
