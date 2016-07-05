namespace Ong.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adocao : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Adocoes",
                c => new
                    {
                        AdocaoId = c.Int(nullable: false, identity: true),
                        AdocaoAdotante = c.String(),
                        AdocaoGato = c.String(),
                    })
                .PrimaryKey(t => t.AdocaoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Adocoes");
        }
    }
}
