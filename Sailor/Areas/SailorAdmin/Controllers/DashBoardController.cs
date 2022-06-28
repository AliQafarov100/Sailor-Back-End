using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Sailor.Areas.SailorAdmin.Controllers
{
    [Area("SailorAdmin")]
    [Authorize(Roles = "SuperAdmin, Admin")]
    public class DashBoardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
