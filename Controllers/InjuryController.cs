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

namespace Lab8.Controllers
{
    [Authorize (Roles="Runner,Admin,Coach,Trainer")]
    public class InjuryController : Controller
    {
        private IInjuryRepository _InjuryRepo;
        private Lab8Settings _Settings;
        private IMemoryCache _Cache;
         public InjuryController(IMemoryCache cache,IOptionsSnapshot<Lab8Settings> settings, IInjuryRepository InjuryRepo)
        {
            _Settings = settings.Value;
            _Cache = cache;
            _InjuryRepo = InjuryRepo; 
        }
        public async Task<IActionResult> Index()
        {
            List<InjuryModel> InjuryList = new List<InjuryModel>();
            InjuryList.AddRange(await  _InjuryRepo.GetList());
            return View(InjuryList);
        }
        [Authorize (Roles="Runner")]
        [HttpGet]
        public IActionResult PostInjury()
        {
            InjuryModel model = new InjuryModel();
            model.Date = DateTime.Now;
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult PostInjury(InjuryModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            return Create(model);
        }

        protected IActionResult Create(InjuryModel model)
        {
            _InjuryRepo.Save(model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            InjuryModel Injury = _InjuryRepo.Get(id);
            return View(Injury);
        }
        public IActionResult View(int id)
        {
            InjuryModel a = _InjuryRepo.Get(id);
            return View(a);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _InjuryRepo.Delete(id);
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
