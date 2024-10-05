using Hackatones.Shered.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hackatones.Shared.Entities
{
    public class Project
    {

        public int Id { get; set; }

        [Display(Name = "Nombre del proyecto")]
        [MaxLength(50, ErrorMessage = "El {0}, no puede tener mas de 50 caractere.")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string Name { get; set; }

        [Display(Name = " Descripcion del proyecto")]
        [MaxLength(250, ErrorMessage = "El {0}, no puede tener mas de 250 caractere.")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string Description { get; set; }


        [Display(Name = " Estado del proyecto")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string Status { get; set; }

        [Display(Name = "Fecha inicio del proyecto")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Fecha de entrega del proyecto")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd HH:mm}")]
        public DateTime DeliveryDate { get; set; }


        [Display(Name = " direccion URL del proyecto")]
        [Required(ErrorMessage = "El {0} es obligatorio")]
        public string RepositoryUrl { get; set; }

        [JsonIgnore]
        public Hackaton Hackatons { get; set; }
        public int HackatonId { get; set; }

        [JsonIgnore]
        public Team Teams { get; set; }
        public int TeamId { get; set; }

        [JsonIgnore]
        public ICollection<Evaluation> Evaluations { get; set; }

    } 
}
