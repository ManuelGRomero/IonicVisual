namespace Practica_Ajax.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MunicipiosyEstado : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Estadoes",
                c => new
                    {
                        estadoID = c.Int(nullable: false, identity: true),
                        nombreEstado = c.String(),
                    })
                .PrimaryKey(t => t.estadoID);
            
            CreateTable(
                "dbo.Municipios",
                c => new
                    {
                        municipioID = c.Int(nullable: false, identity: true),
                        nombreMunicipio = c.String(),
                        estadoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.municipioID)
                .ForeignKey("dbo.Estadoes", t => t.estadoID, cascadeDelete: true)
                .Index(t => t.estadoID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Municipios", "estadoID", "dbo.Estadoes");
            DropIndex("dbo.Municipios", new[] { "estadoID" });
            DropTable("dbo.Municipios");
            DropTable("dbo.Estadoes");
        }
    }
}
