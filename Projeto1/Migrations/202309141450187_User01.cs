namespace Projeto1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class User01 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.User", "IdDeparment", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.User", "IdDeparment");
        }
    }
}
