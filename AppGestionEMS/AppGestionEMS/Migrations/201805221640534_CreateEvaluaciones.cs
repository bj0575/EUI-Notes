namespace AppGestionEMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateEvaluaciones : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Evaluaciones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CursoId = c.Int(nullable: false),
                        idUsuario = c.String(),
                        tipoConvocatoria = c.Int(nullable: false),
                        trabajo1 = c.Single(nullable: false),
                        trabajo2 = c.Single(nullable: false),
                        trabajo3 = c.Single(nullable: false),
                        notaTeoria = c.Single(nullable: false),
                        notaPractica = c.Single(nullable: false),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cursos", t => t.CursoId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .Index(t => t.CursoId)
                .Index(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Evaluaciones", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Evaluaciones", "CursoId", "dbo.Cursos");
            DropIndex("dbo.Evaluaciones", new[] { "User_Id" });
            DropIndex("dbo.Evaluaciones", new[] { "CursoId" });
            DropTable("dbo.Evaluaciones");
        }
    }
}
