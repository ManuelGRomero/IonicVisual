namespace Practica_Ajax.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Especificaciones : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Especificaciones",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        modelo = c.String(),
                        costo = c.String(),
                        ram = c.String(),
                        procesador = c.String(),
                        hdd = c.String(),
                        dimensiones = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Especificaciones");
        }
    }
}
