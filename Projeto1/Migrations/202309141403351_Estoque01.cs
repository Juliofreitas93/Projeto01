namespace Projeto1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Estoque01 : DbMigration
    {
        public override void Up()
        {            
            AlterColumn("dbo.Estoque", "Description", c => c.String(nullable: false, maxLength: 100, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Estoque", "Description", c => c.String());
          
        }
    }
}
