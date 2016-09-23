namespace PesquisaEleitoral.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _002 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Candidato", "CandidatoNome", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Candidato", "CandidatoNome", c => c.String());
        }
    }
}
