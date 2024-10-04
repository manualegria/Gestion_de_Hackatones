using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hackatones.Shared.Entities
{
    public class TeamAward
    {

        public int Id { get; set; }

        [Display(Name = "Fecha de otorgamiento")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}")]
        public DateTime AwardDate { get; set; }

        [JsonIgnore]
        public Award Awards { get; set; }  
        public int AwardId { get; set; }    
    }
}
