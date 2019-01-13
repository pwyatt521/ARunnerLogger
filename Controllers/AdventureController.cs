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

namespace Lab8.Controllers
{
    [Authorize (Roles="Adventurer")]
    public class AdventureController : Controller
    {
        private IAdventureRepository _AdventureRepo;
        private Lab8Settings _Settings;
        private IMemoryCache _Cache;
         public AdventureController(IMemoryCache cache,IOptionsSnapshot<Lab8Settings> settings, IAdventureRepository adventureRepo)
        {
            _Settings = settings.Value;
            _Cache = cache;
            _AdventureRepo = adventureRepo; 
        }
        public async Task<IActionResult> Index()
        {
            List<AdventureModel> adventureList = new List<AdventureModel>();
            adventureList.AddRange(await  _AdventureRepo.GetList());
            return View(adventureList);
        }

        [HttpGet]
        public IActionResult PostBlog()
        {
            AdventureModel model = new AdventureModel();
            model.AName = _Settings.DefaultName;
            model.ARating = _Settings.DefaultRating;
            model.PostedBy = _Settings.DefaultUser;
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult PostBlog(AdventureModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
                //return RedirectToAction("Index");

            }
            return Create(model);
        }

        protected IActionResult Create(AdventureModel model)
        {
            _AdventureRepo.Save(model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            AdventureModel adventure = _AdventureRepo.Get(id);
            return View(adventure);
        }
        public IActionResult View(int id)
        {
            AdventureModel a = _AdventureRepo.Get(id);
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
