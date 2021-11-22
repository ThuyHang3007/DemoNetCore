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
    public class tes1Controller : Controller
    {
        private readonly ApplicationDbcontext _context;

        public tes1Controller(ApplicationDbcontext context)
        {
            _context = context;
        }

        // GET: tes1
        public async Task<IActionResult> Index()
        {
            return View(await _context.tes1.ToListAsync());
        }

        // GET: tes1/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tes1 = await _context.tes1
                .FirstOrDefaultAsync(m => m.tes1ID == id);
            if (tes1 == null)
            {
                return NotFound();
            }

            return View(tes1);
        }

        // GET: tes1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: tes1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("tes1ID,tes1Name")] tes1 tes1)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tes1);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tes1);
        }

        // GET: tes1/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tes1 = await _context.tes1.FindAsync(id);
            if (tes1 == null)
            {
                return NotFound();
            }
            return View(tes1);
        }

        // POST: tes1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("tes1ID,tes1Name")] tes1 tes1)
        {
            if (id != tes1.tes1ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tes1);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!tes1Exists(tes1.tes1ID))
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
            return View(tes1);
        }

        // GET: tes1/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tes1 = await _context.tes1
                .FirstOrDefaultAsync(m => m.tes1ID == id);
            if (tes1 == null)
            {
                return NotFound();
            }

            return View(tes1);
        }

        // POST: tes1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var tes1 = await _context.tes1.FindAsync(id);
            _context.tes1.Remove(tes1);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool tes1Exists(string id)
        {
            return _context.tes1.Any(e => e.tes1ID == id);
        }
    }
}
