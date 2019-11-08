using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThreeThingAuction.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ThingList ThingList { get; set; }
        public DateTime Date { get; set; }//Used for starting time
        public DateTime EndDate { get; set; }
    }
}
