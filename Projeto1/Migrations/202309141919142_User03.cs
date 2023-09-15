namespace Projeto1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class User03 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.User", name: "Department", newName: "__mig_tmp__0");
            RenameColumn(table: "dbo.User", name: "Deparment", newName: "Department");
            RenameColumn(table: "dbo.User", name: "__mig_tmp__0", newName: "Email_User");
            AlterColumn("dbo.User", "Department", c => c.String(maxLength: 150, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.User", "Department", c => c.String());
            RenameColumn(table: "dbo.User", name: "Email_User", newName: "__mig_tmp__0");
            RenameColumn(table: "dbo.User", name: "Department", newName: "Deparment");
            RenameColumn(table: "dbo.User", name: "__mig_tmp__0", newName: "Department");
        }
    }
}
