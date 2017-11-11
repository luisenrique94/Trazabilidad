namespace Trazabilidad.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Nacimientoes",
                c => new
                    {
                        CodigoId = c.String(nullable: false, maxLength: 5),
                        CodiGanadero = c.String(nullable: false, maxLength: 8),
                        NomGanadero = c.String(),
                        Zona = c.String(),
                        Color = c.String(),
                        Raza = c.String(),
                        Sexo = c.String(),
                        FechaNacimiento = c.DateTime(nullable: false),
                        Peso = c.Int(nullable: false),
                        Enfermedad = c.String(),
                        Medicamentos = c.String(),
                        Padre = c.String(),
                        Madre = c.String(),
                    })
                .PrimaryKey(t => t.CodigoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Nacimientoes");
        }
    }
}
