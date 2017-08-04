using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GummiBearKingdom.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace GummiBearKingdom.Controllers
{
    public class GummiController : Controller
    {
        private GummiKingdomDbContext db = new GummiKingdomDbContext();
        public IActionResult Index()
        {
            return View(db.Gummis.ToList());
        }
    }
}
