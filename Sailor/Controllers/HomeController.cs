using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sailor.DAL;
using Sailor.Models;
using Sailor.ViewModels;

namespace Sailor.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Slider> sliders = await _context.Sliders.ToListAsync();
            List<Card> cards = await _context.Cards.ToListAsync();
            List<Brand> brands = await _context.Brands.ToListAsync();

            HomeVM model = new HomeVM
            {
                Brands = brands,
                Cards = cards,
                Sliders = sliders
            };
            return View(model);
        }
    }
}
