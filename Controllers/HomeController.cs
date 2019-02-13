using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Lab8.Models;
using Coach.Repositories;
using Lab8.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;

namespace Lab8.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private RoleManager<IdentityRole> _RoleManager;
        private UserManager<Lab8Model> _UserManager;
        private ICoachRepository _CoachRepo;
        public HomeController(RoleManager<IdentityRole> roleManager, UserManager<Lab8Model> userManager, ICoachRepository coachRepo)
        {
            _RoleManager = roleManager;
            _UserManager = userManager;
            _CoachRepo = coachRepo;
        }
        public async Task<IActionResult> Index()
        {   
            List<NewsModel> newsList = new List<NewsModel>();
            newsList.AddRange(await _CoachRepo.GetList());
            return View(newsList.Where(m=>m.Date > DateTime.Now.AddDays(-7)));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
