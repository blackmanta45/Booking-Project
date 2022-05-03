using System;
using System.Linq;
using System.Threading.Tasks;
using Core.Common.Enums;
using Core.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Presentation.Controllers
{
    public class RoomsController : Controller
    {
        private readonly AppDbContext _context;

        public RoomsController(AppDbContext context)
        {
            this._context = context;
        }

        // GET: Rooms
        public async Task<IActionResult> Index() => this.View(await this._context.Rooms.ToListAsync());

        // GET: Rooms/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return this.NotFound();
            }

            var room = await this._context.Rooms
                .FirstOrDefaultAsync(m => m.Id == id);
            if (room == null)
            {
                return this.NotFound();
            }

            return this.View(room);
        }

        // GET: Rooms/Create
        public IActionResult Create() => this.View();

        // POST: Rooms/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Amount,IsDeleted")] Room room)
        {
            room.Id = Guid.NewGuid();
            room.Type = await this._context.Set<RoomType>().Where(x => x.People == AvailableRoomSize.Person1 && x.Stars == 2).FirstOrDefaultAsync();
            room.Hotel = await this._context.Set<Hotel>().FirstOrDefaultAsync();
            this._context.Add(room);
            await this._context.SaveChangesAsync();
            return this.RedirectToAction(nameof(this.Index));
        }

        // GET: Rooms/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return this.NotFound();
            }

            var room = await this._context.Rooms.FindAsync(id);
            if (room == null)
            {
                return this.NotFound();
            }

            return this.View(room);
        }

        // POST: Rooms/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Amount,Id,IsDeleted,CreatedAt,ModifiedAt")] Room room)
        {
            if (id != room.Id)
            {
                return this.NotFound();
            }

            if (this.ModelState.IsValid)
            {
                try
                {
                    this._context.Update(room);
                    await this._context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!this.RoomExists(room.Id))
                    {
                        return this.NotFound();
                    }

                    throw;
                }

                return this.RedirectToAction(nameof(this.Index));
            }

            return this.View(room);
        }

        // GET: Rooms/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return this.NotFound();
            }

            var room = await this._context.Rooms
                .FirstOrDefaultAsync(m => m.Id == id);
            if (room == null)
            {
                return this.NotFound();
            }

            return this.View(room);
        }

        // POST: Rooms/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var room = await this._context.Rooms.FindAsync(id);
            this._context.Rooms.Remove(room);
            await this._context.SaveChangesAsync();
            return this.RedirectToAction(nameof(this.Index));
        }

        private bool RoomExists(Guid id) => this._context.Rooms.Any(e => e.Id == id);
    }
}