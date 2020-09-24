namespace ProdutivedadeBasquete.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Primeiro : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Jogadoras",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Nascimento = c.DateTime(nullable: false),
                        RecordeDePontos = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Partidas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdJogadora = c.Int(nullable: false),
                        NumJogo = c.Int(nullable: false),
                        Placar = c.Int(nullable: false),
                        QtidadeMinimaPontos = c.Int(nullable: false),
                        QtidadeMaximaPontos = c.Int(nullable: false),
                        RecordeMinimoPontos = c.Int(nullable: false),
                        RecordeMaximoPontos = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Partidas");
            DropTable("dbo.Jogadoras");
        }
    }
}
