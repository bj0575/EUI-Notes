namespace AppGestionEMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateAsignacionDocente : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AsignacionDocentes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        CursoId = c.Int(nullable: false),
                        GrupoId = c.Int(nullable: false),
                        UsuarioId = c.Int(nullable: false),
                        Usuario_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Cursos", t => t.CursoId, cascadeDelete: true)
                .ForeignKey("dbo.GrupoClases", t => t.GrupoId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.Usuario_Id)
                .Index(t => t.CursoId)
                .Index(t => t.GrupoId)
                .Index(t => t.Usuario_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AsignacionDocentes", "Usuario_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AsignacionDocentes", "GrupoId", "dbo.GrupoClases");
            DropForeignKey("dbo.AsignacionDocentes", "CursoId", "dbo.Cursos");
            DropIndex("dbo.AsignacionDocentes", new[] { "Usuario_Id" });
            DropIndex("dbo.AsignacionDocentes", new[] { "GrupoId" });
            DropIndex("dbo.AsignacionDocentes", new[] { "CursoId" });
            DropTable("dbo.AsignacionDocentes");
        }
    }
}
