using exam.DAL;
using exam.Models;
using exam.Utilies;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace exam.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class CategoryController : Controller
    {
        private AppDbContext _context;
        private IWebHostEnvironment _env;

        public CategoryController(AppDbContext context,IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {

            return View(_context.Dinners.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Dinner dinner)
        {
            if (dinner.Photo.CheckSize(800))
            {
                ModelState.AddModelError("Photo", "File size must be less than 800kb");
                return View();
            }
            if (!dinner.Photo.CheckType("image/"))
            {
                ModelState.AddModelError("Photo", "File must be image");
                return View();
            }
            dinner.Img = await dinner.Photo.SaveFileAsync(Path.Combine(_env.WebRootPath, "assets", "img"));
            await _context.Dinners.AddAsync(dinner);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            Dinner dinner = _context.Dinners.Find(id);
            if (dinner == null) return NotFound();
            if (System.IO.File.Exists(Path.Combine(_env.WebRootPath, "assets", "img", dinner.Img)))
            {
                System.IO.File.Delete(Path.Combine(_env.WebRootPath, "assets", "img", dinner.Img));
            }
            _context.Dinners.Remove(dinner);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Edit(int id)
        {
            Dinner dinner = _context.Dinners.FirstOrDefault(c => c.Id == id);
            if (dinner == null) return NotFound();
            return View(dinner);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Dinner dinner)
        {
            if (ModelState.IsValid)
            {
                var d = await _context.Dinners.FindAsync(dinner.Id);
                d.Name = dinner.Name;
                d.Desc = dinner.Desc;
                if (dinner.Photo != null)
                {
                    if (dinner.Img != null)
                    {
                        string filePath = Path.Combine(_env.WebRootPath, "assets", "img", dinner.Img);
                        System.IO.File.Delete(filePath);
                    }
                    d.Img = ProcessUploadedFile(dinner);
                }
                _context.Update(d);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        private string ProcessUploadedFile(Dinner dinner)
        {
            string uniqueFileName = null;

            if (dinner.Photo != null)
            {
                string uploadsFolder = Path.Combine(_env.WebRootPath, "assets", "img");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + dinner.Photo.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    dinner.Photo.CopyTo(fileStream);
                }
            }

            return uniqueFileName;
        }
    }
    
}
