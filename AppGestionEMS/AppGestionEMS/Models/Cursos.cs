using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace AppGestionEMS.Models
{
    public class Cursos
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Nombre"),Required]
        public String nombre { get; set; }
        [Display(Name = "Descripción"), Required]
        public String descripcion { get; set; }

    }
}