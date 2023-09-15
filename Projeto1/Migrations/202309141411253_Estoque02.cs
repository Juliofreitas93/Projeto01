namespace Projeto1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Estoque02 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Estoque", "IdDepartment", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Estoque", "IdDepartment");
        }
    }
}
