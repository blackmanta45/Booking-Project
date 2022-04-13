using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Core.Entities;
using Infrastructure.Data;

namespace Presentation.Controllers
{
    public class RoomPricesController : Controller
    {
        private readonly AppDbContext _context;

        public RoomPricesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: RoomPrices
        public async Task<IActionResult> Index()
        {
            return View(await _context.RoomPrices.ToListAsync());
        }

        // GET: RoomPrices/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roomPrice = await _context.RoomPrices
                .FirstOrDefaultAsync(m => m.Id == id);
            if (roomPrice == null)
            {
                return NotFound();
            }

            return View(roomPrice);
        }

        // GET: RoomPrices/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RoomPrices/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Price,Date,Id,IsDeleted,CreatedAt,ModifiedAt")] RoomPrice roomPrice)
        {
            if (ModelState.IsValid)
            {
                roomPrice.Id = Guid.NewGuid();
                _context.Add(roomPrice);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(roomPrice);
        }

        // GET: RoomPrices/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roomPrice = await _context.RoomPrices.FindAsync(id);
            if (roomPrice == null)
            {
                return NotFound();
            }
            return View(roomPrice);
        }

        // POST: RoomPrices/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Price,Date,Id,IsDeleted,CreatedAt,ModifiedAt")] RoomPrice roomPrice)
        {
            if (id != roomPrice.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(roomPrice);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RoomPriceExists(roomPrice.Id))
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
            return View(roomPrice);
        }

        // GET: RoomPrices/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roomPrice = await _context.RoomPrices
                .FirstOrDefaultAsync(m => m.Id == id);
            if (roomPrice == null)
            {
                return NotFound();
            }

            return View(roomPrice);
        }

        // POST: RoomPrices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var roomPrice = await _context.RoomPrices.FindAsync(id);
            _context.RoomPrices.Remove(roomPrice);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RoomPriceExists(Guid id)
        {
            return _context.RoomPrices.Any(e => e.Id == id);
        }
    }
}
