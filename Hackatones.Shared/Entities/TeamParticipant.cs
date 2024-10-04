using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hackatones.Shered.Entities
{
	public class TeamParticipant
	{
       
		public int Id { get; set; }

        [Display(Name = "roles")]
        [MaxLength(50, ErrorMessage = "El {0}, no puede tener mas de 50 caractere.")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string role { get; set; }

        [Display(Name = "fecha de incorporacion")]
        [MaxLength(10, ErrorMessage = "El {0}, no puede tener mas de 10 caractere.")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public DateTime incorporation_date { get; set; }

        [JsonIgnore]
        public Team teams { get; set; }
        public int TeamId { get; set; }

        [JsonIgnore]
        public Participant Participants { get; set; }   
        public int ParticipantId { get; set; }
	}
}
