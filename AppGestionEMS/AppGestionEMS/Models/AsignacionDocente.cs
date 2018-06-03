using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace AppGestionEMS.Models
{
    public class AsignacionDocente
    {
        public int id { get; set; }
        [Display (Name = "Curso")]
        public int CursoId { get; set; }
        public virtual Cursos Curso {get;set;}

        [Display(Name = "Grupo de clase")]
        public int GrupoId { get; set; }
        public virtual GrupoClase Grupo { get; set; }


        [Display(Name = "Usuario")]
        public string UsuarioId { get; set; }
        public virtual ApplicationUser Usuario { get; set; }
    
    }
}