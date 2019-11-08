using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ThreeThingAuction.Data;
using ThreeThingAuction.Models;

namespace ThreeThingAuction.Areas.Identity.Controllers
{
    [Area("Identity")]
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }

//Index=========================================================
        public IActionResult Index()
        {
            return View();
        }
        //Index=========================================================
        //Team==========================================================
        public async Task<IActionResult> AllThings()
        {
            var teamlist = await _context.ThingLists.ToListAsync();

            return View(teamlist);
        }

        public async Task<IActionResult> TeamList()
        {
            var teamlist = await _context.Teams.ToListAsync();

            return View(teamlist);
        }
        public async Task<IActionResult> AddMoneyToTeam(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var team = await _context.Teams.FindAsync(id);
            if (team == null)
            {
                return NotFound();
            }

            return View(team);
        }

        public async Task<IActionResult> TeamDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var team = await _context.Teams
                .FirstOrDefaultAsync(m => m.Id == id);
            if (team == null)
            {
                return NotFound();
            }

            return View(team);
        }

//Team==========================================================
//Events========================================================
        // GET: Identity/Events/Create
        public IActionResult CreateEvents()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateEvents([Bind("Id,Name,Date,EndDate")] Event @event)
        {
            if (ModelState.IsValid)
            {
                _context.Add(@event);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(EventsList));
            }
            return View(@event);
        }

        public async Task<IActionResult> EventsList()
        {
            return View(await _context.Events.ToListAsync());
        }

        // Get: EditEvents
        public async Task<IActionResult> EditEvents(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @event = await _context.Events.FindAsync(id);
            if (@event == null)
            {
                return NotFound();
            }
            return View(@event);
        }

        // POST: EditEvents
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditEvents(int id, [Bind("Id,Name,Date,EndDate")] Event @event)
        {
            if (id != @event.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(@event);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EventExists(@event.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(@event);
        }
        private bool EventExists(int id)
        {
            return _context.Events.Any(e => e.Id == id);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddMoneyToTeam(int id, [Bind("Id,Name,Money,NoOfMembers,Member1,Member2,Member3,Member4")] Team team)
        {
            if (id != team.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(team);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TeamExists(team.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("TeamList", "Admin", new { area = "Identity" });
            }
            return View(team);
        }
        private bool TeamExists(int id)
        {
            return _context.Teams.Any(e => e.Id == id);
        }
//Events========================================================
//Things========================================================
        // GET: createThings
        public IActionResult CreateThings(string id)
        {
            return View();
        }
        //POST:CreateThings
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateThings([Bind("Id,Name,Owned,EventId")] Thing thing)
        {
            
            //Saving to ThingList table
            var thingname = new ThingList();
            thingname.Name = thing.Name;
            _context.Add(thingname);
            await _context.SaveChangesAsync();

            var eventname = await _context.Events.FirstOrDefaultAsync(i =>i.Name == thing.EventId);
            thing.EventName = eventname.Id;

            if (ModelState.IsValid)
            {
                _context.Add(thing);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(thing);
        }

        public async Task<IActionResult> ThingList(string id)
        {
            var test = await _context.Things.Where(b => b.EventId == id).ToListAsync();
            if (id == null)
            {
                 test = await _context.Things.ToListAsync();
                return View(test);
            }
            return View(test);
        }

        public async Task<IActionResult> ThingDetail(int? id)
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

        public async Task<IActionResult> EditThings(int? id)
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
            return View(thing);
        }

        // POST: Identity/Things/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditThings(int id, [Bind("Id,Name,Teamid,EventId")] Thing thing)
        {
            if (id != thing.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(thing);
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
                return RedirectToAction(nameof(Index));
            }
            return View(thing);
        }
        private bool ThingExists(int id)
        {
            return _context.Things.Any(e => e.Id == id);
        }

        // GET: Identity/Things/Delete/5
        public async Task<IActionResult> DeleteThings(int? id)
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

        //Things========================================================
    }
}