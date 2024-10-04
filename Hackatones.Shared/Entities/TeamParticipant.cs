using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
<<<<<<< HEAD
using System.Text.Json.Serialization;
=======
>>>>>>> main
using System.Threading.Tasks;

namespace Hackatones.Shered.Entities
{
	public class TeamParticipant
	{
<<<<<<< HEAD
       
		public int Id { get; set; }
=======
        //Foranea equipo
		[Display(Name = "identificador equipo")]
		[MaxLength(10, ErrorMessage = "El {0}, no puede tener mas de 10 caractere.")]
		[Required(ErrorMessage = "El {0} es obligatorio")]
		public int idTeamFK { get; set; }
        
        //Foranea participante
        [Display(Name = "identificador participante")]
        [MaxLength(10, ErrorMessage = "El {0}, no puede tener mas de 10 caractere.")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public int idParticipantFK { get; set; }
>>>>>>> main

        [Display(Name = "roles")]
        [MaxLength(50, ErrorMessage = "El {0}, no puede tener mas de 50 caractere.")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string role { get; set; }

        [Display(Name = "fecha de incorporacion")]
        [MaxLength(10, ErrorMessage = "El {0}, no puede tener mas de 10 caractere.")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
<<<<<<< HEAD
        public DateTime incorporation_date { get; set; }

        [JsonIgnore]
        public Team teams { get; set; }
        public int TeamId { get; set; }

        [JsonIgnore]
        public Participant Participants { get; set; }   
        public int ParticipantId { get; set; }
=======
        public DateTime incorporationDate { get; set; }
>>>>>>> main
	}
}
