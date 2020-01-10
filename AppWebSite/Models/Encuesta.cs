using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Xunit;

namespace AppWebSite.Models
{
    public partial class Encuesta
    {
        
        public DateTime Enfecha { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio para el registro")]
        public string Enemail { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio para el registro")]
        public string Ennombre { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio para el registro")]
        public int Encalificacion { get; set; }
    }
}
