using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackatones.Shered.Entities
{
	public class TeamParticipant
	{
        //Foranea equipo
		[Display(Name = "identificador equipo")]
		[MaxLength(10, ErrorMessage = "El {0}, no puede tener mas de 10 caractere.")]
		[Required(ErrorMessage = "El {0} es obligatorio")]
		public int id_team_FK { get; set; }
        
        //Foranea participante
        [Display(Name = "identificador participante")]
        [MaxLength(10, ErrorMessage = "El {0}, no puede tener mas de 10 caractere.")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public int id_participant_FK { get; set; }

        [Display(Name = "roles")]
        [MaxLength(50, ErrorMessage = "El {0}, no puede tener mas de 50 caractere.")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string role { get; set; }

        [Display(Name = "fecha de incorporacion")]
        [MaxLength(10, ErrorMessage = "El {0}, no puede tener mas de 10 caractere.")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public DateTime incorporation_date { get; set; }
	}
}
