using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sailor.Models;

namespace Sailor.Controllers
{
    [Area("SailorAdmin")]
    public class UserController : Controller
    {
        private readonly UserManager<AppUser> _manager;

        public UserController(UserManager<AppUser> manager)
        {
            _manager = manager;
        }
        public async Task<IActionResult> Users()
        {
            List<AppUser> users = await _manager.Users.ToListAsync();
            return View(users);
        }
    }
}
