namespace Projeto1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Department : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Department",
                c => new
                    {
                        IdDepartment = c.Int(nullable: false, identity: true),
                        Name_Deparment = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.IdDepartment);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Department");
        }
    }
}
