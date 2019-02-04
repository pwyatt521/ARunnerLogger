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
using Injury.Repositories;
using Microsoft.Extensions.Caching.Memory;
using Rehab.Repositories;

namespace Lab8.Controllers
{
    [Authorize (Roles="Admin,Trainer")]
    public class TrainerController : Controller
    {
        private IRehabRepository _RehabRepo;
        private Lab8Settings _Settings;
        private IMemoryCache _Cache;
         public TrainerController(IMemoryCache cache,IOptionsSnapshot<Lab8Settings> settings, IRehabRepository RehabRepo)
        {
            _Settings = settings.Value;
            _Cache = cache;
            _RehabRepo = RehabRepo; 
        }
        public async Task<IActionResult> Index()
        {
            List<RehabModel> RehabList = new List<RehabModel>();
            RehabList.AddRange(await  _RehabRepo.GetList());
            return View(RehabList);
        }

        [HttpGet]
        public IActionResult PostRehab()
        {
            RehabModel model = new RehabModel();
            model.timesUsed = 0;
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult PostRehab(RehabModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            return Create(model);
        }

        protected IActionResult Create(RehabModel model)
        {
            _RehabRepo.Save(model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            RehabModel Rehab = _RehabRepo.Get(id);
            return View(Rehab);
        }
        public IActionResult View(int id)
        {
            RehabModel a = _RehabRepo.Get(id);
            return View(a);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _RehabRepo.Delete(id);
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
