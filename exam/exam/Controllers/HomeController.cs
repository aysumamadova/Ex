using exam.DAL;
using exam.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace exam.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            HomeVM homeVM = new HomeVM()
            {
                Breakfasts = await _context.Breakfasts.ToListAsync(),
                Dinners = await _context.Dinners.ToListAsync(),
                Brunches = await _context.Brunches.ToListAsync(),
            };
            return View(homeVM);
        }
    }
}
