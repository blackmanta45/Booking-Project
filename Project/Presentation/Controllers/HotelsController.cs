using System;
using System.Linq;
using System.Threading.Tasks;
using Core.Common.Enums;
using Core.Entities;
using Core.Services;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Presentation.Controllers
{
    public class HotelsController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IHotelService hotelService;

        public HotelsController(AppDbContext context, IHotelService hotelService)
        {
            this._context = context;
            this.hotelService = hotelService;
        }

        // GET: Hotels
        public async Task<IActionResult> Index() => this.View(await this._context.Hotels.ToListAsync());

        // GET: Hotels/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return this.NotFound();
            }

            var hotel = await this._context.Hotels
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hotel == null)
            {
                return this.NotFound();
            }

            return this.View(hotel);
        }

        // GET: Hotels/Create
        public IActionResult Create() => this.View();

        // POST: Hotels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Description,Latitude,Longitude,Quality,Id,IsDeleted,CreatedAt,ModifiedAt")] Hotel hotel)
        {
            if (this.ModelState.IsValid)
            {
                hotel.Id = Guid.NewGuid();
                this._context.Add(hotel);
                await this._context.SaveChangesAsync();
                return this.RedirectToAction(nameof(this.Index));
            }

            return this.View(hotel);
        }

        // GET: Hotels/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return this.NotFound();
            }

            var hotel = await this._context.Hotels.FindAsync(id);
            if (hotel == null)
            {
                return this.NotFound();
            }

            return this.View(hotel);
        }

        // POST: Hotels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Name,Description,Latitude,Longitude,Quality,Id,IsDeleted,CreatedAt,ModifiedAt")] Hotel hotel)
        {
            if (id != hotel.Id)
            {
                return this.NotFound();
            }

            if (this.ModelState.IsValid)
            {
                try
                {
                    this._context.Update(hotel);
                    await this._context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!this.HotelExists(hotel.Id))
                    {
                        return this.NotFound();
                    }

                    throw;
                }

                return this.RedirectToAction(nameof(this.Index));
            }

            return this.View(hotel);
        }

        // GET: Hotels/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return this.NotFound();
            }

            var hotel = await this._context.Hotels
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hotel == null)
            {
                return this.NotFound();
            }

            return this.View(hotel);
        }

        // POST: Hotels/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var hotel = await this._context.Hotels.FindAsync(id);
            this._context.Hotels.Remove(hotel);
            await this._context.SaveChangesAsync();
            return this.RedirectToAction(nameof(this.Index));
        }

        private bool HotelExists(Guid id) => this._context.Hotels.Any(e => e.Id == id);
    }
}