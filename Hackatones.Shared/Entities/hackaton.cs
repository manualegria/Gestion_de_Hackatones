using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Hackatones.Shered.Entities
{
    public class hackaton
    {

        public int Id_hackaton { get; set; }

        [Display(Name = "nombre hackaton")]
        [MaxLength(50, ErrorMessage = "El {0}, no puede tener mas de 50 caractere.")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string Name { get; set; }

        [Display(Name = "fecha de inicio")]
        [MaxLength(10, ErrorMessage = "El {0}, no puede tener mas de 50 caractere.")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string start_date { get; set; }

        [Display(Name = "fecha de finalizacion")]
        [MaxLength(10, ErrorMessage = "El {0}, no puede tener mas de 50 caractere.")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string end_date { get; set; }

        [Display(Name = "tema principal")]
        [MaxLength(50, ErrorMessage = "El {0}, no puede tener mas de 50 caractere.")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string main_topic { get; set; }

        [Display(Name = "organizador")]
        [MaxLength(50, ErrorMessage = "El {0}, no puede tener mas de 50 caractere.")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string organizer { get; set; }

        [Display(Name = "estado (Activo/Finalizado)")]
        [MaxLength(30, ErrorMessage = "El {0}, no puede tener mas de 50 caractere.")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string status { get; set; }
     }
}