using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackatones.Shered.Entities
{
    public class Hackaton
    {
        [Display(Name = "identificador hackaton")]
        [MaxLength(10, ErrorMessage = "El {0}, no puede tener mas de 10 caractere.")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public int idHackaton { get; set; }

        [Display(Name = "nombre hackaton")]
        [MaxLength(50, ErrorMessage = "El {0}, no puede tener mas de 50 caractere.")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string Name { get; set; }

        [Display(Name = "fecha de inicio")]
        [MaxLength(10, ErrorMessage = "El {0}, no puede tener mas de 10 caractere.")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public DateTime startDate { get; set; }

        [Display(Name = "fecha de finalizacion")]
        [MaxLength(10, ErrorMessage = "El {0}, no puede tener mas de 10 caractere.")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public DateTime endDate { get; set; }

        [Display(Name = "tema principal")]
        [MaxLength(50, ErrorMessage = "El {0}, no puede tener mas de 50 caractere.")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string mainTopic { get; set; }

        [Display(Name = "organizador")]
        [MaxLength(50, ErrorMessage = "El {0}, no puede tener mas de 50 caractere.")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string organizer { get; set; }

        [Display(Name = "estado (Activo/Finalizado)")]
        [MaxLength(50, ErrorMessage = "El {0}, no puede tener mas de 30 caractere.")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string status { get; set; }
     }
}