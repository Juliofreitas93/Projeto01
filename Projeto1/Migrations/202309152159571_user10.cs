namespace Projeto1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class user10 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.User", newName: "Table_User");
            AlterColumn("dbo.Table_User", "Password_User", c => c.String(maxLength: 120, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Table_User", "Password_User", c => c.String(maxLength: 20, unicode: false));
            RenameTable(name: "dbo.Table_User", newName: "User");
        }
    }
}
