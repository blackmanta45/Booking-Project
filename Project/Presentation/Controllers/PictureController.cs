using System.IO;
using System.Threading.Tasks;
using Core.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class PictureController : Controller
    {
        private readonly AppDbContext _context;

        public PictureController(AppDbContext context)
        {
            this._context = context;
        }
        

        // GET: Rooms/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Upload()
        {
            foreach (var file in this.Request.Form.Files)
            {
                var img = new Picture();

                var ms = new MemoryStream();
                await file.CopyToAsync(ms);
                img.Bytes = ms.ToArray();

                ms.Close();
                await ms.DisposeAsync();

                this._context.Pictures.Add(img);
                await this._context.SaveChangesAsync();
            }

            return this.View("Create");
        }
    }
}