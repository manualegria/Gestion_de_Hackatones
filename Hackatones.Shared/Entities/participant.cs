using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hackatones.Shered.Entities
{
    public class Participant
	{
		
		public int Id { get; set; }

		[Display(Name = "Nombre del participante")]
		[MaxLength(50, ErrorMessage = "El {0}, no puede tener mas de 50 caractere.")]
		[Required(ErrorMessage = "El {0} es obligatorio")]
		public string Name { get; set; }

		[Display(Name = "Apellido participante")]
		[MaxLength(50, ErrorMessage = "El {0}, no puede tener mas de 50 caractere.")]
		[Required(ErrorMessage = "El {0} es obligatorio")]
		public string LastName { get; set; }

        [Display(Name = "Correo participante")]
        [MaxLength(50, ErrorMessage = "El {0}, no puede tener mas de 50 caractere.")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string Email { get; set; }

        [Display(Name = "Numero celular participante")]
        [MaxLength(50, ErrorMessage = "El {0}, no puede tener mas de 50 caractere.")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string phone { get; set; }

        [Display(Name = "Experiencia en desarrollo")]
        [MaxLength(50, ErrorMessage = "El {0}, no puede tener mas de 50 caractere.")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string developmentExperience { get; set; }

        [Display(Name = "Experiencia en diseño")]
        [MaxLength(50, ErrorMessage = "El {0}, no puede tener mas de 50 caractere.")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string experienceDesign { get; set; }

        [Display(Name = "Experiencia gestion")]
        [MaxLength(50, ErrorMessage = "El {0}, no puede tener mas de 50 caractere.")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string managementExperience { get; set; }


        [JsonIgnore]
        public ICollection<TeamParticipant> TeamParticipants { get; set; }
    }
}
