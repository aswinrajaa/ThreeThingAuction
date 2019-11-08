using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using ThreeThingAuction.Data;
using ThreeThingAuction.Models;

namespace ThreeThingAuction.Areas.Identity.Controllers
{
    [Area("Identity")]
    public class ThingsController : Controller
    {
        string eventid;
        private readonly ApplicationDbContext _context;

        public ThingsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult AllThings()
        {
            return View(_context.ThingLists.ToListAsync());
        }

        // GET: Identity/Things
        public async Task<IActionResult> Index(string id)
        {
            
            if (id == null)
            {
                return NotFound();
            }
            var test = await _context.Things.Where(b => b.EventId == id).ToListAsync();
            if (test.Count==0)
            {
                return RedirectToAction("Index", "Events");
            }

            return View(test);
        }

        public async Task<IActionResult> Result(string id)
        {
            var test = await _context.Things.Where(b => b.EventId == id).ToListAsync();
            if (id == null)
            {
                id = eventid;
                test = await _context.Things.Where(b => b.EventId == id).ToListAsync();
                return View(test);
            }
            eventid = id;


            return View(test);
        }

        // GET: Identity/Things/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thing = await _context.Things
                .FirstOrDefaultAsync(m => m.Id == id);
            if (thing == null)
            {
                return NotFound();
            }

            return View(thing);
        }

        // GET: Identity/Things/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Identity/Things/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Owned")] Thing thing)
        {
            if (ModelState.IsValid)
            {
                _context.Add(thing);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(thing);
        }

        // GET: Identity/Things/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thing = await _context.Things.FindAsync(id);
            if (thing == null)
            {
                return NotFound();
            }
            thing.BidValue = 0;
            return View(thing);
        }

        // POST: Identity/Things/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Owned,BidValue,EventId,EventName")] Thing thing)
        {
            
            if (id != thing.Id)
            {
                return NotFound();
            }
            
            var thinglist = _context.Things.Find(id);
            if (thinglist.BidValue == null) {
                thinglist.BidValue = 0;
            }
            if (thinglist.BidValue < thing.BidValue) {
                var currentTeam = await _context.Teams.Where(i => i.Id == thinglist.Teamid).ToListAsync();
                
                var userName = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                var user = await _context.Users.Where(i => i.ASPNetUserID == userName).ToListAsync();

                string currentBidConv = thinglist.BidValue.ToString();
                int CurrentBidConvd = int.Parse(currentBidConv);
                string newBidConv = thing.BidValue.ToString();
                int newBidConvd = int.Parse(newBidConv);

                if (thinglist.Teamid != null)
                {
                    foreach (var t in currentTeam)
                    {
                        t.Money = t.Money + CurrentBidConvd;
                    }
                }

                foreach (var u in user)
                {
                    var newTeam = await _context.Teams.Where(i => i.Id == u.TeamID).ToListAsync();
                    foreach (var b in newTeam)
                    {
                        b.Money = b.Money - newBidConvd;
                    }
                    thinglist.Teamid = u.TeamID;
                }
                
               
                thinglist.BidValue = thing.BidValue;

                foreach (var u in user)
                {
                    thinglist.Teamid = u.TeamID;
                }

                if (ModelState.IsValid)
                {
                    try
                    {
                        _context.Update(thinglist);
                        
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!ThingExists(thing.Id))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                    return RedirectToAction("Index", new RouteValueDictionary( new { controller = "Things", action = "Index", Id = thing.EventId }));
                }
            }
            return RedirectToAction("Index", new RouteValueDictionary(new { controller = "Things", action = "Index", Id = thing.EventId }));
        }

        // GET: Identity/Things/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var thing = await _context.Things
                .FirstOrDefaultAsync(m => m.Id == id);
            if (thing == null)
            {
                return NotFound();
            }

            return View(thing);
        }

        // POST: Identity/Things/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var thing = await _context.Things.FindAsync(id);
            _context.Things.Remove(thing);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ThingExists(int id)
        {
            return _context.Things.Any(e => e.Id == id);
        }
    }
}
