namespace Projeto1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class User02 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.User", name: "Email_User", newName: "Department");
            AddColumn("dbo.User", "Deparment", c => c.String());
            DropColumn("dbo.User", "IdDeparment");
        }
        
        public override void Down()
        {
            AddColumn("dbo.User", "IdDeparment", c => c.Int(nullable: false));
            DropColumn("dbo.User", "Deparment");
            RenameColumn(table: "dbo.User", name: "Department", newName: "Email_User");
        }
    }
}
