using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThreeThingAuction.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Money { get; set; }
        public Event Event { get; set; }
        public int NoOfMembers { get; set; }
        public string Member1 { get; set; }
        public string Member2 { get; set; }
        public string Member3 { get; set; }
        public string Member4 { get; set; }
    }
}
