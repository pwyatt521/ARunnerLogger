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
using Coach.Repositories;

namespace Lab8.Controllers
{
    [Authorize (Roles="Coach,Runner,Trainer,Admin")]
    public class CoachController : Controller
    {
        private ICoachRepository _CoachRepo;
        private Lab8Settings _Settings;
        private IMemoryCache _Cache;
         public CoachController(IMemoryCache cache,IOptionsSnapshot<Lab8Settings> settings, ICoachRepository CoachRepo)
        {
            _Settings = settings.Value;
            _Cache = cache;
            _CoachRepo = CoachRepo; 
        }
        public async Task<IActionResult> Index()
        {
            List<NewsModel> NewsList = new List<NewsModel>();
            NewsList.AddRange(await  _CoachRepo.GetList());
            return View(NewsList);
        }

        [Authorize (Roles="Coach,Admin")]
        [HttpGet]
        public IActionResult PostNews()
        {
            NewsModel model = new NewsModel();
            model.Date = DateTime.Now;
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult PostNews(NewsModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            return Create(model);
        }

        protected IActionResult Create(NewsModel model)
        {
            _CoachRepo.Save(model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            NewsModel News = _CoachRepo.Get(id);
            return View(News);
        }
        public IActionResult View(int id)
        {
            NewsModel a = _CoachRepo.Get(id);
            return View(a);
        }

        [Authorize (Roles="Coach,Admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _CoachRepo.Delete(id);
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
