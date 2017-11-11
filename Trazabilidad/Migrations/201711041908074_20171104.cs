namespace Trazabilidad.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _20171104 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Destetes",
                c => new
                    {
                        CodigoId = c.String(nullable: false, maxLength: 5),
                        CodiGanadero = c.String(nullable: false, maxLength: 8),
                        Zona = c.String(),
                        Color = c.String(),
                        Raza = c.String(),
                        Sexo = c.String(),
                        FechaDestete = c.DateTime(nullable: false),
                        Peso = c.Int(nullable: false),
                        Enfermedad = c.String(),
                        Medicamentos = c.String(),
                    })
                .PrimaryKey(t => t.CodigoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Destetes");
        }
    }
}
