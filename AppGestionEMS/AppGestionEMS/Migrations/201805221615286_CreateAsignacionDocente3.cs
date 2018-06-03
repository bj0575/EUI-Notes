namespace AppGestionEMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateAsignacionDocente3 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.AsignacionDocentes", new[] { "Usuario_Id" });
            DropColumn("dbo.AsignacionDocentes", "UsuarioId");
            RenameColumn(table: "dbo.AsignacionDocentes", name: "Usuario_Id", newName: "UsuarioId");
            AlterColumn("dbo.AsignacionDocentes", "UsuarioId", c => c.String(maxLength: 128));
            CreateIndex("dbo.AsignacionDocentes", "UsuarioId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.AsignacionDocentes", new[] { "UsuarioId" });
            AlterColumn("dbo.AsignacionDocentes", "UsuarioId", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.AsignacionDocentes", name: "UsuarioId", newName: "Usuario_Id");
            AddColumn("dbo.AsignacionDocentes", "UsuarioId", c => c.Int(nullable: false));
            CreateIndex("dbo.AsignacionDocentes", "Usuario_Id");
        }
    }
}
