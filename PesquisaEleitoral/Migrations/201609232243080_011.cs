namespace PesquisaEleitoral.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _011 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AspNetUsers", "BairroContext_BairroId", "dbo.Bairro");
            DropIndex("dbo.AspNetUsers", new[] { "BairroContext_BairroId" });
            AddColumn("dbo.AspNetUsers", "BairroContext", c => c.Int(nullable: false));
            DropColumn("dbo.AspNetUsers", "BairroContext_BairroId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "BairroContext_BairroId", c => c.Int());
            DropColumn("dbo.AspNetUsers", "BairroContext");
            CreateIndex("dbo.AspNetUsers", "BairroContext_BairroId");
            AddForeignKey("dbo.AspNetUsers", "BairroContext_BairroId", "dbo.Bairro", "BairroId");
        }
    }
}
