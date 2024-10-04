using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hackatones.Shared.Entities
{
    public class Evaluation
    {
        public int Id { get; set; }


        [Display(Name = "Nota de innovacion")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public decimal InnovationScore { get; set; }


        [Display(Name = "Nota de funcionalidad")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public decimal FunctionalityScore { get; set; }


        [Display(Name = "Comentarios sebr ela evaluacion")]
        [MaxLength(250, ErrorMessage = "El {0}, no puede tener mas de 250 caractere.")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string Comments { get; set; }


        [Display(Name = "Fecha de evaluacion")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}")]
        public DateTime EvaluationDate { get; set; }


        [JsonIgnore]
        public Project Projects { get; set; }
        public int ProjectId { get; set; }

        [JsonIgnore]
        public Mentor Mentors { get; set; }
        public int MentorId { get; set; }
    }
}
