namespace AppGestionEMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateMatriculas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Matriculas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        CursoId = c.Int(nullable: false),
                        GrupoId = c.Int(nullable: false),
                        UsuarioId = c.String(maxLength: 128),
                        codigo = c.String(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Cursos", t => t.CursoId, cascadeDelete: true)
                .ForeignKey("dbo.GrupoClases", t => t.GrupoId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UsuarioId)
                .Index(t => t.CursoId)
                .Index(t => t.GrupoId)
                .Index(t => t.UsuarioId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Matriculas", "UsuarioId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Matriculas", "GrupoId", "dbo.GrupoClases");
            DropForeignKey("dbo.Matriculas", "CursoId", "dbo.Cursos");
            DropIndex("dbo.Matriculas", new[] { "UsuarioId" });
            DropIndex("dbo.Matriculas", new[] { "GrupoId" });
            DropIndex("dbo.Matriculas", new[] { "CursoId" });
            DropTable("dbo.Matriculas");
        }
    }
}
