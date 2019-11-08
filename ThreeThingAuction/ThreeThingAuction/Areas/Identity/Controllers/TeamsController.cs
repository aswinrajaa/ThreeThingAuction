using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ThreeThingAuction.Data;
using ThreeThingAuction.Models;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace ThreeThingAuction.Areas.Identity.Controllers
{
    [Area("Identity")]
    public class TeamsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TeamsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Identity/Teams
        public async Task<IActionResult> Index()
        {
            var userName = User.FindFirst(ClaimTypes.Name).Value;
            var user = await _context.Users.Where(i => i.Name == userName).ToListAsync();
            var teamlist = await _context.Teams.ToListAsync();
            foreach (var u in user)
            {
                if (u.TeamID == null)
                {
                    break;
                }
                else
                {
                    foreach (var t in teamlist)
                    {
                        if (u.TeamID == t.Id)
                        {
                            return RedirectToAction("Details", t);
                        }
                    }
                }
            }
            

            return View(teamlist);
        }

        // GET: Identity/Teams/Details/5
        public async Task<IActionResult> Details(int? id)
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

        // GET: Identity/Teams/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Identity/Teams/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Money,NoOfMembers")] Team team)
        {
            if (ModelState.IsValid)
            {
                _context.Add(team);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(team);
        }

        // GET: Identity/Teams/Edit/5
        public async Task<IActionResult> Edit(int? id)
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

        // POST: Identity/Teams/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Money,NoOfMembers,Member1,Member2,Member3,Member4")] Team team)
        {
            var userName = User.FindFirst(ClaimTypes.Name).Value;
            if (id != team.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var user = _context.Users.ToList();                
                foreach (var u in user)
                {
                    if (u.Name == userName)
                    {
                        if (u.TeamID == null)
                        {
                            if (team.Member1 == null)
                            {
                                team.Member1 = userName;
                            }
                            else if (team.Member2 == null)
                            {
                                team.Member2 = userName;
                            }
                            else if (team.Member3 == null)
                            {
                                team.Member3 = userName;
                            }
                            else
                            {
                                team.Member4 = userName;
                            }
                            team.NoOfMembers++;
                            u.TeamID = team.Id;
                            _context.Update(u);
                        }
                    }
                }
                
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
                return RedirectToAction("Index","Events",new { area = "Identity"});
            }
            return View(team);
        }

        // GET: Identity/Teams/Leave/5
        public async Task<IActionResult> Leave(int? id)
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

        // POST: Identity/Teams/Leave/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Leave(int id, [Bind("Id,Name,Money,NoOfMembers,Member1,Member2,Member3,Member4")] Team team)
        {
            var userName = User.FindFirst(ClaimTypes.Name).Value;
            if (id != team.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var user = _context.Users.ToList();
                foreach (var u in user)
                {
                    if (u.Name == userName)
                    {
                        u.TeamID = null;
                        _context.Update(u);
                    }
                }
                if (userName == team.Member1)
                {
                    if (team.Member4 == userName)
                    {
                        team.Member1 = team.Member4;
                        team.Member4 = null;
                    }
                    else if (team.Member3 == userName)
                    {
                        team.Member1 = team.Member3;
                        team.Member3 = null;
                    }
                    else if (team.Member2 == userName)
                    {
                        team.Member1 = team.Member2;
                        team.Member2 = null;
                    }
                    else
                    {
                        team.Member1 = null;
                    }
                }
                else if(userName == team.Member2)
                {
                    if (team.Member4 == userName)
                    {
                        team.Member2 = team.Member4;
                        team.Member4 = null;
                    }
                    else if (team.Member3 == userName)
                    {
                        team.Member2 = team.Member3;
                        team.Member3 = null;
                    }
                    else 
                    {
                        team.Member2 = null;
                    }
                }
                else if (userName == team.Member3)
                {
                    if (team.Member4 == userName)
                    {
                        team.Member3 = team.Member4;
                        team.Member4 = null;
                    }
                    else
                    {
                        team.Member3 = null;
                    }
                }
                else if (userName == team.Member4)
                {
                    team.Member4 = null;
                }

                try
                {
                    team.NoOfMembers--;
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
                return RedirectToAction("Index", "Events", new { area = "Identity" });
            }
            return View(team);
        }

        // GET: Identity/Teams/Delete/5
        public async Task<IActionResult> Delete(int? id)
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

        // POST: Identity/Teams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var team = await _context.Teams.FindAsync(id);
            _context.Teams.Remove(team);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TeamExists(int id)
        {
            return _context.Teams.Any(e => e.Id == id);
        }
    }
}
