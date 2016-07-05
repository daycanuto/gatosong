namespace Ong.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Adocoes", "AdotanteId", c => c.Int(nullable: false));
            AddColumn("dbo.Adocoes", "GatoId", c => c.Int(nullable: false));
            AddColumn("dbo.Gato", "AdocaoId", c => c.Int(nullable: false));
            CreateIndex("dbo.Adocoes", "AdotanteId");
            AddForeignKey("dbo.Adocoes", "AdotanteId", "dbo.Adotante", "AdotanteId", cascadeDelete: true);
            DropColumn("dbo.Adocoes", "AdocaoAdotante");
            DropColumn("dbo.Adocoes", "AdocaoGato");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Adocoes", "AdocaoGato", c => c.String());
            AddColumn("dbo.Adocoes", "AdocaoAdotante", c => c.String());
            DropForeignKey("dbo.Adocoes", "AdotanteId", "dbo.Adotante");
            DropIndex("dbo.Adocoes", new[] { "AdotanteId" });
            DropColumn("dbo.Gato", "AdocaoId");
            DropColumn("dbo.Adocoes", "GatoId");
            DropColumn("dbo.Adocoes", "AdotanteId");
        }
    }
}
