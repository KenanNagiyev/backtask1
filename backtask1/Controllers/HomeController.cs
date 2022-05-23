using backtask1.DAL;
using backtask1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backtask1.Controllers
{
    public class HomeController : Controller
    {
        private AppdbContext _context { get; }
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            List<Slider> sliders = _context.Sliders.ToList();
            return View(sliders);
        }
    }
}
