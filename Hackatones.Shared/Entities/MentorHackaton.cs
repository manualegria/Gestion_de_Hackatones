using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Hackatones.Shared.Entities
{
    public class MentorHackaton
    {
        public int id {  get; set; }


        [JsonIgnore]
        public Mentor Mentors { get; set; }
        public int MentorId { get; set; }


        [JsonIgnore]
        public Hackaton Hackatons { get; set; }
        public int HackatonId { get; set; }

    }
}
