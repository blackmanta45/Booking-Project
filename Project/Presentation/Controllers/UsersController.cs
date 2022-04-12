using System;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Presentation.Controllers
{
    public class UsersController : Controller
    {
        private readonly AppDbContext _context;

        public UsersController(AppDbContext context)
        {
            this._context = context;
        }

        // GET: Users
        public async Task<IActionResult> Index() => this.View(await this._context.Users.ToListAsync());

        // GET: Users/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return this.NotFound();
            }

            var user = await this._context.Users
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return this.NotFound();
            }

            return this.View(user);
        }

        // GET: Users/Create
        public IActionResult Create() => this.View();

        // POST: Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Surname,DateOfBirth,Email,Phone,Gender,Id,IsDeleted,CreatedAt,ModifiedAt")] User user)
        {
            if (this.ModelState.IsValid)
            {
                user.Id = Guid.NewGuid();
                this._context.Add(user);
                await this._context.SaveChangesAsync();
                return this.RedirectToAction(nameof(this.Index));
            }

            return this.View(user);
        }

        // GET: Users/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return this.NotFound();
            }

            var user = await this._context.Users.FindAsync(id);
            if (user == null)
            {
                return this.NotFound();
            }

            return this.View(user);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Name,Surname,DateOfBirth,Email,Phone,Gender,Id,IsDeleted,CreatedAt,ModifiedAt")] User user)
        {
            if (id != user.Id)
            {
                return this.NotFound();
            }

            if (this.ModelState.IsValid)
            {
                try
                {
                    this._context.Update(user);
                    await this._context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!this.UserExists(user.Id))
                    {
                        return this.NotFound();
                    }

                    throw;
                }

                return this.RedirectToAction(nameof(this.Index));
            }

            return this.View(user);
        }

        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return this.NotFound();
            }

            var user = await this._context.Users
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return this.NotFound();
            }

            return this.View(user);
        }

        // POST: Users/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var user = await this._context.Users.FindAsync(id);
            this._context.Users.Remove(user);
            await this._context.SaveChangesAsync();
            return this.RedirectToAction(nameof(this.Index));
        }

        private bool UserExists(Guid id) => this._context.Users.Any(e => e.Id == id);
    }
}