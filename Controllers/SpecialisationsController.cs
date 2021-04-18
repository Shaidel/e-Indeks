using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AndrewApp.Contexts;
using AndrewApp.Models;

namespace AndrewApp.Controllers
{
    public class SpecialisationsController : Controller
    {
        private readonly MainContext _context;

        public SpecialisationsController(MainContext context)
        {
            _context = context;
        }

        // GET: Specialisations
        public async Task<IActionResult> Index()
        {
            var mainContext = _context.Specialisations.Include(s => s.Department);
            return View(await mainContext.ToListAsync());
        }

        // GET: Specialisations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var specialisation = await _context.Specialisations
                .Include(s => s.Department)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (specialisation == null)
            {
                return NotFound();
            }

            return View(specialisation);
        }

        // GET: Specialisations/Create
        public IActionResult Create()
        {
            ViewData["DepartmentId"] = new SelectList(_context.Departments, "Id", "Name");
            return View();
        }

        // POST: Specialisations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DepartmentId,Name")] Specialisation specialisation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(specialisation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DepartmentId"] = new SelectList(_context.Departments, "Id", "Name", specialisation.DepartmentId);
            return View(specialisation);
        }

        // GET: Specialisations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var specialisation = await _context.Specialisations.FindAsync(id);
            if (specialisation == null)
            {
                return NotFound();
            }
            ViewData["DepartmentId"] = new SelectList(_context.Departments, "Id", "Name", specialisation.DepartmentId);
            return View(specialisation);
        }

        // POST: Specialisations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DepartmentId,Name")] Specialisation specialisation)
        {
            if (id != specialisation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(specialisation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SpecialisationExists(specialisation.Id))
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
            ViewData["DepartmentId"] = new SelectList(_context.Departments, "Id", "Name", specialisation.DepartmentId);
            return View(specialisation);
        }

        // GET: Specialisations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var specialisation = await _context.Specialisations
                .Include(s => s.Department)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (specialisation == null)
            {
                return NotFound();
            }

            return View(specialisation);
        }

        // POST: Specialisations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var specialisation = await _context.Specialisations.FindAsync(id);
            _context.Specialisations.Remove(specialisation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SpecialisationExists(int id)
        {
            return _context.Specialisations.Any(e => e.Id == id);
        }
    }
}
