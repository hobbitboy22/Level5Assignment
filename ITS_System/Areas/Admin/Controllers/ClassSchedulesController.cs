﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ITS_System.Data;
using ITS_System.Models;
using Microsoft.AspNetCore.Identity;

namespace FlexAppealFitness.Areas.Admin
{
    [Area("Admin")]
    public class ClassSchedulesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public ClassSchedulesController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Admin/ClassSchedules
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Schedule.Include(c => c.Room).Include(c => c.Instructor);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Admin/ClassSchedules/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Schedule == null)
            {
                return NotFound();
            }

            var classSchedule = await _context.Schedule
                .Include(c => c.Room)
                .Include(c => c.Instructor)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (classSchedule == null)
            {
                return NotFound();
            }

            return View(classSchedule);
        }

        // GET: Admin/ClassSchedules/Create
        public async Task<IActionResult> Create()
        {
            ViewData["RoomId"] = new SelectList(_context.Rooms, "Id", "Description");
            ViewData["InstructorId"] = new SelectList(await _userManager.GetUsersInRoleAsync("Instructor"), "Id","Email");
            return View();
        }

        // POST: Admin/ClassSchedules/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DateTime,MaxNumbersOfBooking,RoomId,Status")] ClassSchedule classSchedule)
        {
            if (ModelState.IsValid)
            {
                _context.Add(classSchedule);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["RoomId"] = new SelectList(_context.Rooms, "Id", "Description", classSchedule.RoomId);
            ViewData["InstructorId"] = new SelectList(await _userManager.GetUsersInRoleAsync("Instructor"), "Id", "Email");
            return View(classSchedule);
        }

        // GET: Admin/ClassSchedules/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Schedule == null)
            {
                return NotFound();
            }

            var classSchedule = await _context.Schedule.FindAsync(id);
            if (classSchedule == null)
            {
                return NotFound();
            }
            ViewData["RoomId"] = new SelectList(_context.Rooms, "Id", "Description", classSchedule.RoomId);
            ViewData["InstructorId"] = new SelectList(_context.Users, "Id", "Email");
            ViewData["EquipmentId"] = new SelectList(_context.Equpiments, "Id", "Description");
            return View(classSchedule);
        }

        // POST: Admin/ClassSchedules/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DateTime,MaxNumbersOfBooking,RoomId,Status")] ClassSchedule classSchedule)
        {
            if (id != classSchedule.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(classSchedule);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClassScheduleExists(classSchedule.Id))
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
            ViewData["RoomId"] = new SelectList(_context.Rooms, "Id", "Description", classSchedule.RoomId);
            ViewData["Instructor"] = new SelectList(_context.Users, "Id", "Email", classSchedule.InstructorId);
            return View(classSchedule);
        }

        // GET: Admin/ClassSchedules/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Schedule == null)
            {
                return NotFound();
            }

            var classSchedule = await _context.Schedule
                .Include(c => c.Room)
                .Include(c => c.Instructor)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (classSchedule == null)
            {
                return NotFound();
            }

            return View(classSchedule);
        }

        // POST: Admin/ClassSchedules/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Schedule == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Schedule'  is null.");
            }
            var classSchedule = await _context.Schedule.FindAsync(id);
            if (classSchedule != null)
            {
                _context.Schedule.Remove(classSchedule);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClassScheduleExists(int id)
        {
          return (_context.Schedule?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
