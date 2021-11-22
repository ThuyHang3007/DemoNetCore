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
    public class demokethuaController : Controller
    {
        private readonly ApplicationDbcontext _context;

        public demokethuaController(ApplicationDbcontext context)
        {
            _context = context;
        }

        // GET: demokethua
        public async Task<IActionResult> Index()
        {
            return View(await _context.demokethua.ToListAsync());
        }

        // GET: demokethua/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var demokethua = await _context.demokethua
                .FirstOrDefaultAsync(m => m.PersonID == id);
            if (demokethua == null)
            {
                return NotFound();
            }

            return View(demokethua);
        }

        // GET: demokethua/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: demokethua/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("demokethuaID,demokethuatName,PersonID,PersonName")] demokethua demokethua)
        {
            if (ModelState.IsValid)
            {
                _context.Add(demokethua);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(demokethua);
        }

        // GET: demokethua/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var demokethua = await _context.demokethua.FindAsync(id);
            if (demokethua == null)
            {
                return NotFound();
            }
            return View(demokethua);
        }

        // POST: demokethua/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("demokethuaID,demokethuatName,PersonID,PersonName")] demokethua demokethua)
        {
            if (id != demokethua.PersonID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(demokethua);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!demokethuaExists(demokethua.PersonID))
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
            return View(demokethua);
        }

        // GET: demokethua/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var demokethua = await _context.demokethua
                .FirstOrDefaultAsync(m => m.PersonID == id);
            if (demokethua == null)
            {
                return NotFound();
            }

            return View(demokethua);
        }

        // POST: demokethua/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var demokethua = await _context.demokethua.FindAsync(id);
            _context.demokethua.Remove(demokethua);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool demokethuaExists(int id)
        {
            return _context.demokethua.Any(e => e.PersonID == id);
        }
    }
}
