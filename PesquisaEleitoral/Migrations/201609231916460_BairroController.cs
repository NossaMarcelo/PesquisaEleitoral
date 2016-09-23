namespace PesquisaEleitoral.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BairroController : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bairro",
                c => new
                    {
                        BairroId = c.Int(nullable: false, identity: true),
                        BairroNome = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.BairroId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Bairro");
        }
    }
}
