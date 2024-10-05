using Hackatones.Shered.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hackatones.Shared.Entities
{
    public class HackatonTeam
    {

        public int Id { get; set; }


        [JsonIgnore]
        public Hackaton Hackatons { get; set; }
        public int HackatonId { get; set; }

        [JsonIgnore]
        public Team Teams { get; set; }
        public int TeamId { get; set; }


    }
}
