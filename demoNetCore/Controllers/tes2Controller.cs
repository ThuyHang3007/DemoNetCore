using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using demoNetCore.Models;

namespace demoNetCore.Controllers
{
    public class tes2Controller : Controller
    {
        private readonly ApplicationDbcontext _context;

        public tes2Controller(ApplicationDbcontext context)
        {
            _context = context;
        }

        // GET: tes2
        public async Task<IActionResult> Index()
        {
            var applicationDbcontext = _context.tes2.Include(t => t.tes1);
            return View(await applicationDbcontext.ToListAsync());
        }

        // GET: tes2/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tes2 = await _context.tes2
                .Include(t => t.tes1)
                .FirstOrDefaultAsync(m => m.ProducttID == id);
            if (tes2 == null)
            {
                return NotFound();
            }

            return View(tes2);
        }

        // GET: tes2/Create
        public IActionResult Create()
        {
            ViewData["tes1ID"] = new SelectList(_context.tes1, "tes1ID", "tes1Name");
            return View();
        }

        // POST: tes2/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProducttID,ProducttName,UnitPrice,Quantity,tes1ID")] tes2 tes2)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tes2);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["tes1ID"] = new SelectList(_context.tes1, "tes1ID", "tes1Name", tes2.tes1ID);
            return View(tes2);
        }

        // GET: tes2/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tes2 = await _context.tes2.FindAsync(id);
            if (tes2 == null)
            {
                return NotFound();
            }
            ViewData["tes1ID"] = new SelectList(_context.tes1, "tes1ID", "tes1Name", tes2.tes1ID);
            return View(tes2);
        }

        // POST: tes2/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ProducttID,ProducttName,UnitPrice,Quantity,tes1ID")] tes2 tes2)
        {
            if (id != tes2.ProducttID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tes2);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!tes2Exists(tes2.ProducttID))
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
            ViewData["tes1ID"] = new SelectList(_context.tes1, "tes1ID", "tes1Name", tes2.tes1ID);
            return View(tes2);
        }

        // GET: tes2/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tes2 = await _context.tes2
                .Include(t => t.tes1)
                .FirstOrDefaultAsync(m => m.ProducttID == id);
            if (tes2 == null)
            {
                return NotFound();
            }

            return View(tes2);
        }

        // POST: tes2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var tes2 = await _context.tes2.FindAsync(id);
            _context.tes2.Remove(tes2);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool tes2Exists(string id)
        {
            return _context.tes2.Any(e => e.ProducttID == id);
        }
    }
}
