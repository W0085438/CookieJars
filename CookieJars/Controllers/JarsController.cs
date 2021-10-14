using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CookieJars.Data;
using CookieJars.Models;

namespace CookieJars.Controllers
{
    public class JarsController : Controller
    {
        private readonly CookieJarsContext _context;

        public JarsController(CookieJarsContext context)
        {
            _context = context;
        }

        // GET: Jars
        public async Task<IActionResult> Index()
        {
            return View(await _context.Jars.ToListAsync());
        }

        // GET: Jars/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jars = await _context.Jars
                .FirstOrDefaultAsync(m => m.Id == id);
            if (jars == null)
            {
                return NotFound();
            }

            return View(jars);
        }

        // GET: Jars/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Jars/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Material,Coating,Rarity,Price,Rating")] Jars jars)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jars);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(jars);
        }

        // GET: Jars/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jars = await _context.Jars.FindAsync(id);
            if (jars == null)
            {
                return NotFound();
            }
            return View(jars);
        }

        // POST: Jars/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Material,Coating,Rarity,Price,Rating")] Jars jars)
        {
            if (id != jars.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jars);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JarsExists(jars.Id))
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
            return View(jars);
        }

        // GET: Jars/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jars = await _context.Jars
                .FirstOrDefaultAsync(m => m.Id == id);
            if (jars == null)
            {
                return NotFound();
            }

            return View(jars);
        }

        // POST: Jars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jars = await _context.Jars.FindAsync(id);
            _context.Jars.Remove(jars);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JarsExists(int id)
        {
            return _context.Jars.Any(e => e.Id == id);
        }
    }
}
