using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CleanTooth.Data;
using CleanTooth.Models;

namespace CleanTooth.Controllers
{
    public class ToothPicksController : Controller
    {
        private readonly CleanToothContext _context;

        public ToothPicksController(CleanToothContext context)
        {
            _context = context;
        }

        // GET: ToothPicks
        public async Task<IActionResult> Index(string searchString)
        {
            var toothpicks = from t in _context.ToothPick
                         select t;

            if (!String.IsNullOrEmpty(searchString))
            {
                toothpicks = toothpicks.Where(s => s.Material.Contains(searchString));
            }

            return View(await toothpicks.ToListAsync());

        }

        // GET: ToothPicks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var toothPick = await _context.ToothPick
                .FirstOrDefaultAsync(m => m.Id == id);
            if (toothPick == null)
            {
                return NotFound();
            }

            return View(toothPick);
        }

        // GET: ToothPicks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ToothPicks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Material,Color,Length,Width,Price,Quailty")] ToothPick toothPick)
        {
            if (ModelState.IsValid)
            {
                _context.Add(toothPick);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(toothPick);
        }

        // GET: ToothPicks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var toothPick = await _context.ToothPick.FindAsync(id);
            if (toothPick == null)
            {
                return NotFound();
            }
            return View(toothPick);
        }

        // POST: ToothPicks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Material,Color,Length,Width,Price,Quailty")] ToothPick toothPick)
        {
            if (id != toothPick.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(toothPick);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ToothPickExists(toothPick.Id))
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
            return View(toothPick);
        }

        // GET: ToothPicks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var toothPick = await _context.ToothPick
                .FirstOrDefaultAsync(m => m.Id == id);
            if (toothPick == null)
            {
                return NotFound();
            }

            return View(toothPick);
        }

        // POST: ToothPicks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var toothPick = await _context.ToothPick.FindAsync(id);
            _context.ToothPick.Remove(toothPick);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ToothPickExists(int id)
        {
            return _context.ToothPick.Any(e => e.Id == id);
        }
    }
}
