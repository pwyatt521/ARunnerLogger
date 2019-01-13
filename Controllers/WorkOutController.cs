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
using WorkOut.Repositories;
using Microsoft.Extensions.Caching.Memory;

namespace Lab8.Controllers
{
    [Authorize (Roles="WorkOuter")]
    public class WorkOutController : Controller
    {
        private IWorkOutRepository _WorkOutRepo;
        private Lab8Settings _Settings;
        private IMemoryCache _Cache;
         public WorkOutController(IMemoryCache cache,IOptionsSnapshot<Lab8Settings> settings, IWorkOutRepository WorkOutRepo)
        {
            _Settings = settings.Value;
            _Cache = cache;
            _WorkOutRepo = WorkOutRepo; 
        }
        public async Task<IActionResult> Index()
        {
            List<WorkOutModel> WorkOutList = new List<WorkOutModel>();
            WorkOutList.AddRange(await  _WorkOutRepo.GetList());
            return View(WorkOutList);
        }

        [HttpGet]
        public IActionResult PostBlog()
        {
            WorkOutModel model = new WorkOutModel();
            model.WName = _Settings.DefaultName;
            model.WRating = _Settings.DefaultRating;
            model.PostedBy = _Settings.DefaultUser;
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult PostBlog(WorkOutModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
                //return RedirectToAction("Index");

            }
            return Create(model);
        }

        protected IActionResult Create(WorkOutModel model)
        {
            _WorkOutRepo.Save(model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            WorkOutModel WorkOut = _WorkOutRepo.Get(id);
            return View(WorkOut);
        }
        public IActionResult View(int id)
        {
            WorkOutModel a = _WorkOutRepo.Get(id);
            return View(a);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _WorkOutRepo.Delete(id);
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
