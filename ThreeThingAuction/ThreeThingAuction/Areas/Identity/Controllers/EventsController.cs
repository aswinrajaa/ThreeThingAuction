using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ThreeThingAuction.Data;
using ThreeThingAuction.Models;

namespace ThreeThingAuction.Areas.Identity.Controllers
{
    [Area("Identity")]
    public class EventsController : Controller
    {
        
        private readonly ApplicationDbContext _context;
        
        public EventsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Identity/Events
        public async Task<IActionResult> Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return View(await _context.Events.ToListAsync());

            }
            else
            {
                Response.Redirect("Account\\Login", true);
            }
            return View(await _context.Events.ToListAsync());

        }

        // GET: Identity/Events/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            var userName = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var user = await _context.Users.Where(i => i.ASPNetUserID == userName).ToListAsync();
            foreach (var u in user)
            {
                if(u.TeamID == null)
                {
                    return RedirectToAction("Index","Teams");
                }
            }
            if (id == null)
            {
                return NotFound();
            }

            var @event = await _context.Events.FirstOrDefaultAsync(m => m.Id == id);
            if (@event == null)
            {
                return NotFound();
            }

            return View(@event);
        }
        public async Task<IActionResult> Things(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ///
            /// add code for selecting correct ID
            /// 
            
            
            /// 
            /// 
            ///
            
            
            // int id = thingListTest.Id;
            //Event @event = await _context.Events.FindAsync(id);
            //int thingListId = @event.ThingList.Id;

            var thinglist = await _context.Things.Where(b => b.ThingList.Id == 1).ToListAsync();

            return View(thinglist);
        }

        // GET: Identity/Events/Create
        public IActionResult Create()
        {
            return View();
        }



        // POST: Identity/Events/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Date,EndDate")] Event @event)
        {
            if (ModelState.IsValid)
            {
                _context.Add(@event);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(@event);
        }

        // GET: Identity/Events/Edit/5
        public async Task<IActionResult> Edit(int? id)
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

        // POST: Identity/Events/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Date,EndDate")] Event @event)
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

        // GET: Identity/Events/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var @event = await _context.Events
                .FirstOrDefaultAsync(m => m.Id == id);
            if (@event == null)
            {
                return NotFound();
            }

            return View(@event);
        }

        // POST: Identity/Events/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var @event = await _context.Events.FindAsync(id);
            _context.Events.Remove(@event);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EventExists(int id)
        {
            return _context.Events.Any(e => e.Id == id);
        }
    }


   
}
