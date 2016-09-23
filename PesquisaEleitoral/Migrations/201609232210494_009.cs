namespace PesquisaEleitoral.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _009 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "BairroContext_BairroId", c => c.Int());
            CreateIndex("dbo.AspNetUsers", "BairroContext_BairroId");
            AddForeignKey("dbo.AspNetUsers", "BairroContext_BairroId", "dbo.Bairro", "BairroId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "BairroContext_BairroId", "dbo.Bairro");
            DropIndex("dbo.AspNetUsers", new[] { "BairroContext_BairroId" });
            DropColumn("dbo.AspNetUsers", "BairroContext_BairroId");
        }
    }
}
