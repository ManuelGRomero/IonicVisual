namespace Practica_Ajax.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class prueba : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Productoes", "proveedor", c => c.String());
            DropColumn("dbo.Productoes", "proovedor");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Productoes", "proovedor", c => c.String());
            DropColumn("dbo.Productoes", "proveedor");
        }
    }
}
