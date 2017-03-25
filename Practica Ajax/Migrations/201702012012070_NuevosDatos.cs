namespace Practica_Ajax.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NuevosDatos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Productoes", "proveedor", c => c.String());
            AddColumn("dbo.Productoes", "peso", c => c.String());
            AddColumn("dbo.Productoes", "descripcion", c => c.String());
            AddColumn("dbo.Productoes", "cantidadAlmacen", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Productoes", "cantidadAlmacen");
            DropColumn("dbo.Productoes", "descripcion");
            DropColumn("dbo.Productoes", "peso");
            DropColumn("dbo.Productoes", "proveedor");
        }
    }
}
