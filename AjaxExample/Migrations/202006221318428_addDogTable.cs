namespace AjaxExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDogTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Nickname = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Dogs");
        }
    }
}
