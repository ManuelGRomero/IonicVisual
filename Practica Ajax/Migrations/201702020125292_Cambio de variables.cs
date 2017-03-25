namespace Practica_Ajax.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Cambiodevariables : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Productoes", "proovedor", c => c.String());
            AddColumn("dbo.Productoes", "stock", c => c.Int(nullable: false));
            DropColumn("dbo.Productoes", "proveedor");
            DropColumn("dbo.Productoes", "cantidadAlmacen");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Productoes", "cantidadAlmacen", c => c.Int(nullable: false));
            AddColumn("dbo.Productoes", "proveedor", c => c.String());
            DropColumn("dbo.Productoes", "stock");
            DropColumn("dbo.Productoes", "proovedor");
        }
    }
}
