using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThreeThingAuction.Models
{
    public class Thing
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Owned { get; set; }
        public int? Teamid { get; set; }
        public int? BidValue { get; set; }
        public string EventId { get; set; }
        public int? EventName { get; set; }
        public ThingList ThingList { get; set; }
    }
}
