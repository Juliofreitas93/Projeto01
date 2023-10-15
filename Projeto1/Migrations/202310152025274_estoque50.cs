namespace Projeto1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class estoque50 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Estoque", "Department", c => c.String(nullable: false, maxLength: 100, unicode: false));
            DropColumn("dbo.Estoque", "IdDepartment");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Estoque", "IdDepartment", c => c.String(nullable: false, maxLength: 100, unicode: false));
            DropColumn("dbo.Estoque", "Department");
        }
    }
}
