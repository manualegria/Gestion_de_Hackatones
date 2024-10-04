using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hackatones.Shered.Entities
{
	public class Team
	{
        
        public int Id { get; set; }
        
      

        [Display(Name = "Nombre del equipo")]
        [MaxLength(50, ErrorMessage = "El {0}, no puede tener mas de 50 caractere.")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string TeamName { get; set; }



        [Display(Name = "Fecha de registro")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}")]
        public DateTime registrationDate { get; set; }

        [Display(Name = "Numero de miembros del equipo")]
        [MaxLength(10, ErrorMessage = "El {0}, no puede tener mas de 10 caractere.")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public int numberMembers { get; set; }

        [JsonIgnore]
        public Team Teams { get; set; }
        public int TeamId { get; set; }

    }
}
