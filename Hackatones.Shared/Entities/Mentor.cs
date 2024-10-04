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
		
        public int Id { get; set; }

        [Display(Name = "Nombre del mentor")]
        [MaxLength(50, ErrorMessage = "El {0}, no puede tener mas de 50 caractere.")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string Name { get; set; }

        [Display(Name = "Apellido del mentor")]
        [MaxLength(50, ErrorMessage = "El {0}, no puede tener mas de 50 caractere.")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string LastName { get; set; }

        [Display(Name = "Correo del mentor")]
		[MaxLength(50, ErrorMessage = "El {0}, no puede tener mas de 50 caractere.")]
		[Required(ErrorMessage = "El {0} es obligatorio")]
		public string Email { get; set; }

        [Display(Name = "Telefonodel  mentor")]
        [MaxLength(10, ErrorMessage = "El {0}, no puede tener mas de 10 caractere.")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string Phone { get; set; }

        [Display(Name = "Especialidad del mentor")]
        [MaxLength(50, ErrorMessage = "El {0}, no puede tener mas de 50 caractere.")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string Epecialty { get; set; }
    }
}
