using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Sailor.DAL;
using Sailor.Extension;
using Sailor.Models;
using Sailor.Utilities;

namespace Sailor.Areas.SailorAdmin.Controllers
{
    [Area("SailorAdmin")]
    public class SlidersController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public SlidersController(AppDbContext context,IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        // GET: SailorAdmin/Sliders
        public async Task<IActionResult> Index()
        {
            return View(await _context.Sliders.ToListAsync());
        }

        // GET: SailorAdmin/Sliders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var slider = await _context.Sliders
                .FirstOrDefaultAsync(m => m.Id == id);
            if (slider == null)
            {
                return NotFound();
            }

            return View(slider);
        }

        // GET: SailorAdmin/Sliders/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SailorAdmin/Sliders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Slider slider)
        {
            if (ModelState.IsValid)
            {
                if(slider.Photo != null)
                {
                    slider.Image = await slider.Photo.FileCreate(_env.WebRootPath, @"assets\Image\Slider");

                    _context.Add(slider);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ModelState.AddModelError("Photo", "Please choose image file");
                    return View();
                }
            }
            return View(slider);
        }

        // GET: SailorAdmin/Sliders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var slider = await _context.Sliders.FindAsync(id);
            if (slider == null)
            {
                return NotFound();
            }
            return View(slider);
        }

        // POST: SailorAdmin/Sliders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,Slider slider)
        {
            Slider existed = await _context.Sliders.FindAsync(id);
            if (id != slider.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (slider.Photo.IsMb(1))
                    {
                        existed.Image = await slider.Photo.FileCreate(_env.WebRootPath, @"assets\Image\Slider");

                        string path = _env.WebRootPath + @"assets\Image\Slider" + existed.Image;

                        if (System.IO.File.Exists(path))
                        {
                            System.IO.File.Delete(path);
                        }
                    }
                  
                    
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SliderExists(slider.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                existed.Title = slider.Title;
                existed.SubTitle = slider.SubTitle;
                existed.Order = slider.Order;
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(slider);
        }

        // GET: SailorAdmin/Sliders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var slider = await _context.Sliders
                .FirstOrDefaultAsync(m => m.Id == id);
            if (slider == null)
            {
                return NotFound();
            }
            

            return View(slider);
        }

        // POST: SailorAdmin/Sliders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var slider = await _context.Sliders.FindAsync(id);
            string path = _env.WebRootPath + @"assets\Image\Slider" + slider.Image;

            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }
            _context.Sliders.Remove(slider);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SliderExists(int id)
        {
            return _context.Sliders.Any(e => e.Id == id);
        }
    }
}
