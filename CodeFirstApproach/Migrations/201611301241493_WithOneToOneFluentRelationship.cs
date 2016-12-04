namespace CodeFirstApproach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WithOneToOneFluentRelationship : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.CodeFirstTest");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.CodeFirstTest",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreatedDate = c.DateTime(),
                        UpdatedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
    }
}
