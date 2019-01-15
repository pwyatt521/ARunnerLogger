using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Lab8.Models;
using Lab8.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;

namespace Lab8.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private RoleManager<IdentityRole> _RoleManager;
        private UserManager<Lab8Model> _UserManager;
        public HomeController(RoleManager<IdentityRole> roleManager, UserManager<Lab8Model> userManager)
        {
            _RoleManager = roleManager;
            _UserManager = userManager;
        }
        public IActionResult Index()
        {   
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
