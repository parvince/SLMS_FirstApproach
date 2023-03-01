using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SLMS_FirstApproach.Models;

namespace SLMS_FirstApproach.Controllers
{
    public class AdminLeavesController : Controller
    {
        private readonly SLMSContext _context;

        public AdminLeavesController(SLMSContext context)
        {
            _context = context;
        }

        // GET: AdminLeaves
        public async Task<IActionResult> Index()
        {
            var sLMSContext = _context.AdminLeaves.Include(a => a.Admin).Include(a => a.Leave);
            return View(await sLMSContext.ToListAsync());
        }

        // GET: AdminLeaves/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adminLeave = await _context.AdminLeaves
                .Include(a => a.Admin)
                .Include(a => a.Leave)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (adminLeave == null)
            {
                return NotFound();
            }

            return View(adminLeave);
        }

        // GET: AdminLeaves/Create
        public IActionResult Create()
        {
            ViewData["AdminId"] = new SelectList(_context.Admins, "Id", "Id");
            ViewData["LeaveId"] = new SelectList(_context.Leaves, "Id", "Id");
            return View();
        }

        // POST: AdminLeaves/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AdminId,LeaveId,Status,AdminRemark,AdminLeaveId")] AdminLeave adminLeave)
        {
            if (ModelState.IsValid)
            {
                _context.Add(adminLeave);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AdminId"] = new SelectList(_context.Admins, "Id", "Id", adminLeave.AdminId);
            ViewData["LeaveId"] = new SelectList(_context.Leaves, "Id", "Id", adminLeave.LeaveId);
            return View(adminLeave);
        }

        // GET: AdminLeaves/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adminLeave = await _context.AdminLeaves.FindAsync(id);
            if (adminLeave == null)
            {
                return NotFound();
            }
            ViewData["AdminId"] = new SelectList(_context.Admins, "Id", "Id", adminLeave.AdminId);
            ViewData["LeaveId"] = new SelectList(_context.Leaves, "Id", "Id", adminLeave.LeaveId);
            return View(adminLeave);
        }

        // POST: AdminLeaves/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AdminId,LeaveId,Status,AdminRemark,AdminLeaveId")] AdminLeave adminLeave)
        {
            if (id != adminLeave.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(adminLeave);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdminLeaveExists(adminLeave.Id))
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
            ViewData["AdminId"] = new SelectList(_context.Admins, "Id", "Id", adminLeave.AdminId);
            ViewData["LeaveId"] = new SelectList(_context.Leaves, "Id", "Id", adminLeave.LeaveId);
            return View(adminLeave);
        }

        // GET: AdminLeaves/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adminLeave = await _context.AdminLeaves
                .Include(a => a.Admin)
                .Include(a => a.Leave)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (adminLeave == null)
            {
                return NotFound();
            }

            return View(adminLeave);
        }

        // POST: AdminLeaves/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var adminLeave = await _context.AdminLeaves.FindAsync(id);
            _context.AdminLeaves.Remove(adminLeave);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdminLeaveExists(int id)
        {
            return _context.AdminLeaves.Any(e => e.Id == id);
        }
    }
}
