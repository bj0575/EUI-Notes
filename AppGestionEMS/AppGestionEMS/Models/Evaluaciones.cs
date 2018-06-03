using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace AppGestionEMS.Models
{
    public class Evaluaciones
    {
     
        public enum ConvocatoriaType
        {
            Ordinaria,
            Extraordinaria
        }
        public int Id { get; set; }
        [Display(Name = "Curso")]
        public int CursoId { get; set; }
        public virtual Cursos Curso { get; set; }


        [Display(Name = "Alumno")]
        public string UsuarioId { get; set; }
        public virtual ApplicationUser Usuario { get; set; }


        public ConvocatoriaType tipoConvocatoria { get; set; }
        public float trabajo1 { get; set; }
        public float trabajo2 { get; set; }
        public float trabajo3 { get; set; }
        public float notaTeoria { get; set; }
        public float notaPractica { get; set; }
     }
}