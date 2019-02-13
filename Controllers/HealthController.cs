using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Lab8.Models;
using Lab8.Areas.Identity.Data;
using Microsoft.Extensions.Options;
using Health.Repositories;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.AspNetCore.Identity;


namespace Lab8.Controllers
{
    [Authorize (Roles="Admin,Coach,Runner,Trainer")]
    public class HealthController : Controller
    {
        private IHealthRepository _HealthRepo;
        private Lab8Settings _Settings;
        private IMemoryCache _Cache;
        RoleManager<IdentityRole> RoleManager;
        UserManager<Lab8Model> UserManager;
         public HealthController(IMemoryCache cache,IOptionsSnapshot<Lab8Settings> settings, IHealthRepository HealthRepo,
                    RoleManager<IdentityRole> roleManager, UserManager<Lab8Model> userManager)
        {
            _Settings = settings.Value;
            _Cache = cache;
            _HealthRepo = HealthRepo; 
            RoleManager = roleManager;
            UserManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            List<HealthModel> logList = new List<HealthModel>();
            logList.AddRange(await  _HealthRepo.GetList());
            if (User.IsInRole("Runner"))
            {
                //TODO: change to SQL Command
                List<HealthModel> runnerList = new List<HealthModel>();
                string username = UserManager.GetUserName(this.User);
                foreach (HealthModel log in logList){
                    if (log.PostedBy == username)
                    {
                        runnerList.Add(log);
                    }
                }
                return View(runnerList);
            }            
            return View(logList);
        }

        [Authorize (Roles="Runner")]
        [HttpGet]
        public IActionResult PostBlog()
        {
            HealthModel model = new HealthModel();
            model.AName = _Settings.DefaultName;
            model.Rating = _Settings.DefaultRating;
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult PostBlog(HealthModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
                //return RedirectToAction("Index");

            }
            return Create(model);
        }

        protected IActionResult Create(HealthModel model)
        {
            _HealthRepo.Save(model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            HealthModel Health = _HealthRepo.Get(id);
            return View(Health);
        }
        public IActionResult View(int id)
        {
            HealthModel a = _HealthRepo.Get(id);
            return View(a);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _HealthRepo.Delete(id);
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
