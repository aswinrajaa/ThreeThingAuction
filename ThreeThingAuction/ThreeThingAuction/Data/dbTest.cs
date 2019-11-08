using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThreeThingAuction.Models;
using Microsoft.EntityFrameworkCore;


namespace ThreeThingAuction.Data
{
    public static class dbTest
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();
            if (context.ThingLists.Any())
            {
                return;
            }
            var thinglist = new ThingList[]
            {
                new ThingList{Id = 1, Name = "A"},
                new ThingList{Id = 2, Name = "B"},
                new ThingList{Id = 3, Name = "C"},
                new ThingList{Id = 4, Name = "D"},
                new ThingList{Id = 5, Name = "E"},
                new ThingList{Id = 6, Name = "F"}
            };
            foreach(ThingList t in thinglist)
            {
                context.ThingLists.Add(t);
            }
            context.SaveChanges();
            var test = context.ThingLists.First();
            var things = new Thing[]
            {
                new Thing{Id = 1, Name = "test1", Owned = false},
                new Thing{Id = 2, Name = "test2", Owned = false},
                new Thing{Id = 3, Name = "test3", Owned = false},
                new Thing{Id = 4, Name = "test4", Owned = false}
            };
            foreach (Thing t in things)
            {
                context.Things.Add(t);
            }
            context.SaveChanges();

            var eventList = new Event[]
           {
                new Event{Id = 1, Name = "A", Date = DateTime.Now},
                new Event{Id = 2, Name = "B", Date = DateTime.Now},
                new Event{Id = 3, Name = "C", Date = DateTime.Now},
                new Event{Id = 4, Name = "D", Date = DateTime.Now},
                new Event{Id = 5, Name = "E", Date = DateTime.Now},
                new Event{Id = 6, Name = "F", Date = DateTime.Now}
           };
            foreach (Event t in eventList)
            {
                context.Events.Add(t);
            }
            context.SaveChanges();
        }


    }
}
