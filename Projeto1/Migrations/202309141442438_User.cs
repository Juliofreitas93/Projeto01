namespace Projeto1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class User : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.User",
                c => new
                    {
                        IdUser = c.Int(nullable: false, identity: true),
                        Name_User = c.String(maxLength: 100, unicode: false),
                        Email_User = c.String(maxLength: 150, unicode: false),
                        PassWord_User = c.String(maxLength: 20, unicode: false),
                        Data_Created = c.DateTime(nullable: false),
                        Data_Modified = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdUser);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.User");
        }
    }
}
