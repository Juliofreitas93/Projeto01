namespace Projeto1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Estoque11 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Estoque", "Unit", c => c.String(nullable: false, maxLength: 100, unicode: false));
            AlterColumn("dbo.Estoque", "IdDepartment", c => c.String(nullable: false, maxLength: 100, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Estoque", "IdDepartment", c => c.Int(nullable: false));
            AlterColumn("dbo.Estoque", "Unit", c => c.Int(nullable: false));
        }
    }
}
