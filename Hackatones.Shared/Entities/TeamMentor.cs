using Hackatones.Shered.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Hackatones.Shared.Entities
{
    public class TeamMentor
    {
        public int Id { get; set; }

        [JsonIgnore]
        public Mentor Mentors   { get; set; }
        public int MentorId { get; set; }

        [JsonIgnore]
        public Team Teams { get; set; }
        public int TeamId { get; set; }

    }
}
