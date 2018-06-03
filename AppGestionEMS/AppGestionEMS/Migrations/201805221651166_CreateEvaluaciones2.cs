namespace AppGestionEMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateEvaluaciones2 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Evaluaciones", name: "User_Id", newName: "UsuarioId");
            RenameIndex(table: "dbo.Evaluaciones", name: "IX_User_Id", newName: "IX_UsuarioId");
            DropColumn("dbo.Evaluaciones", "idUsuario");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Evaluaciones", "idUsuario", c => c.String());
            RenameIndex(table: "dbo.Evaluaciones", name: "IX_UsuarioId", newName: "IX_User_Id");
            RenameColumn(table: "dbo.Evaluaciones", name: "UsuarioId", newName: "User_Id");
        }
    }
}
