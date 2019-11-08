using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThreeThingAuction.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ASPNetUserID { get; set; }
        public int? TeamID { get; set; }
        public Team Team { get; set; }
    }
}
