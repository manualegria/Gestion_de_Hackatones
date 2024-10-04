using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackatones.Shered.Entities
{
    public class Mentor
	{	
		[Display(Name = "identificador de mentor")]
        [MaxLength(10, ErrorMessage = "El {0}, no puede tener mas de 10 caractere.")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public int idMentor { get; set; }

        [Display(Name = "nombre mentor")]
        [MaxLength(50, ErrorMessage = "El {0}, no puede tener mas de 50 caractere.")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string name { get; set; }

        [Display(Name = "apellido mentor")]
        [MaxLength(50, ErrorMessage = "El {0}, no puede tener mas de 50 caractere.")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string lastName { get; set; }

        [Display(Name = "correo mentor")]
		[MaxLength(50, ErrorMessage = "El {0}, no puede tener mas de 50 caractere.")]
		[Required(ErrorMessage = "El {0} es obligatorio")]
		public string email { get; set; }

        [Display(Name = "telefono mentor")]
        [MaxLength(10, ErrorMessage = "El {0}, no puede tener mas de 10 caractere.")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string phone { get; set; }

        [Display(Name = "especialidad mentor")]
        [MaxLength(50, ErrorMessage = "El {0}, no puede tener mas de 50 caractere.")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string specialty { get; set; }
    }
}
