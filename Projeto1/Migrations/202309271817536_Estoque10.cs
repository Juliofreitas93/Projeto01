namespace Projeto1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Estoque10 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Estoque", "Date_Updated", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Estoque", "Date_Updated");
        }
    }
}
