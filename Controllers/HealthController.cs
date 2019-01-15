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
using Adventure.Repositories;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.AspNetCore.Identity;


namespace Lab8.Controllers
{
    [Authorize (Roles="Admin,Coach,Runner,Trainer")]
    public class HealthController : Controller
    {
        private IAdventureRepository _AdventureRepo;
        private Lab8Settings _Settings;
        private IMemoryCache _Cache;
        RoleManager<IdentityRole> RoleManager;
        UserManager<Lab8Model> UserManager;
         public HealthController(IMemoryCache cache,IOptionsSnapshot<Lab8Settings> settings, IAdventureRepository adventureRepo,
                    RoleManager<IdentityRole> roleManager, UserManager<Lab8Model> userManager)
        {
            _Settings = settings.Value;
            _Cache = cache;
            _AdventureRepo = adventureRepo; 
            RoleManager = roleManager;
            UserManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            List<HealthModel> logList = new List<HealthModel>();
            logList.AddRange(await  _AdventureRepo.GetList());
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
            model.ARating = _Settings.DefaultRating;
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
            _AdventureRepo.Save(model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            HealthModel adventure = _AdventureRepo.Get(id);
            return View(adventure);
        }
        public IActionResult View(int id)
        {
            HealthModel a = _AdventureRepo.Get(id);
            return View(a);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _AdventureRepo.Delete(id);
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
