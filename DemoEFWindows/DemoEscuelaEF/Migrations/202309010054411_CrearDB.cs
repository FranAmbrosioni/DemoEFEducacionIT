namespace DemoEscuelaEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CrearDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Profesors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        Apellido = c.String(nullable: false, maxLength: 50, unicode: false),
                        TituloId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Titulo", t => t.TituloId, cascadeDelete: true)
                .Index(t => t.TituloId);
            
            CreateTable(
                "dbo.Titulo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Profesors", "TituloId", "dbo.Titulo");
            DropIndex("dbo.Profesors", new[] { "TituloId" });
            DropTable("dbo.Titulo");
            DropTable("dbo.Profesors");
        }
    }
}
