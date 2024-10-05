using Hackatones.Shared.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hackatones.Shered.Entities
{
    public class Hackaton
    {
        public int Id { get; set; }

        [Display(Name = "nombre hackaton")]
        [MaxLength(50, ErrorMessage = "El {0}, no puede tener mas de 50 caractere.")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string Name { get; set; }

        [Display(Name = "Fecha de evaluacion")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Fecha de evaluacion")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Tema principal")]
        [MaxLength(50, ErrorMessage = "El {0}, no puede tener mas de 50 caractere.")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string MainTopic { get; set; }

        [Display(Name = "Organizador")]
        [MaxLength(50, ErrorMessage = "El {0}, no puede tener mas de 50 caractere.")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string Organizer { get; set; }

        [Display(Name = "Sstado (Activo/Finalizado)")]
        [MaxLength(50, ErrorMessage = "El {0}, no puede tener mas de 30 caractere.")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string Status { get; set; }

        [JsonIgnore]
        public ICollection<MentorHackaton> MentorHackatons { get; set; }

        [JsonIgnore]
        public Team Teams { get; set; }
        public int TeamsId { get; set; }

    }
}