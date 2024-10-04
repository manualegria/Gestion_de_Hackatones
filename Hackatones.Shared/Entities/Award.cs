using Hackatones.Shered.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hackatones.Shared.Entities
{
    public class Award
    {
        public int Id { get; set; }

        [Display(Name = "Nombre del premio")]
        [MaxLength(50, ErrorMessage = "El {0}, no puede tener mas de 50 caractere.")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string AWardName { get; set; }

        [Display(Name = " Descripcion del premio")]
        [MaxLength(250, ErrorMessage = "El {0}, no puede tener mas de 250 caractere.")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string Description { get; set; }

        [Display(Name = "Valor del premio")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public decimal Value { get; set; }

        [Display(Name = "Categoria del premio")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string Category { get; set;}

        [JsonIgnore]
        public Hackaton Hackatons { get; set; }
        public int HackatonId { get; set; }
    }
}
