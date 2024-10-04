using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Hackatones.Shered.Entities
{
    public participant
	{
		[Display(Name = "nombre hackaton")]
		[MaxLength(10, ErrorMessage = "El {0}, no puede tener mas de 10 caractere.")]
		[Required(ErrorMessage = "El {0} es obligatorio")]
		public int id_participant { get; set; }

		[Display(Name = "nombre participante")]
		[MaxLength(50, ErrorMessage = "El {0}, no puede tener mas de 50 caractere.")]
		[Required(ErrorMessage = "El {0} es obligatorio")]
		public string name { get; set; }

		[Display(Name = "apellido participante")]
		[MaxLength(50, ErrorMessage = "El {0}, no puede tener mas de 50 caractere.")]
		[Required(ErrorMessage = "El {0} es obligatorio")]
		public string last_name { get; set; }

        [Display(Name = "correo participante")]
        [MaxLength(50, ErrorMessage = "El {0}, no puede tener mas de 50 caractere.")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string email { get; set; }

        [Display(Name = "numero celular participante")]
        [MaxLength(50, ErrorMessage = "El {0}, no puede tener mas de 50 caractere.")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string phone { get; set; }

        [Display(Name = "experiencia en desarrollo")]
        [MaxLength(50, ErrorMessage = "El {0}, no puede tener mas de 50 caractere.")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string development_experience { get; set; }

        [Display(Name = "experiencia en diseño")]
        [MaxLength(50, ErrorMessage = "El {0}, no puede tener mas de 50 caractere.")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string experience_design { get; set; }

        [Display(Name = "experiencia gestion")]
        [MaxLength(50, ErrorMessage = "El {0}, no puede tener mas de 50 caractere.")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string management_experience { get; set; }
	}
}
