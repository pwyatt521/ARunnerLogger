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
using Repositories.InjuryLog;
using Rehab.Repositories;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.AspNetCore.Identity;


namespace Lab8.Controllers
{
    [Authorize (Roles="Runner,Admin,Coach,Trainer")]
    public class InjuryController : Controller
    {
        private IInjuryRepository _InjuryRepo;
        private IInjuryLogRepository _InjuryLogRepo;
        private IRehabRepository _RehabRepo;
        private Lab8Settings _Settings;
        private IMemoryCache _Cache;
        private UserManager<Lab8Model> _UserManager;

         public InjuryController(IMemoryCache cache,IOptionsSnapshot<Lab8Settings> settings, 
         IInjuryRepository InjuryRepo, IInjuryLogRepository InjuryLogRepo,
         IRehabRepository RehabRepo, UserManager<Lab8Model> UserManager)
        {
            _Settings = settings.Value;
            _Cache = cache;
            _InjuryRepo = InjuryRepo; 
            _InjuryLogRepo = InjuryLogRepo;
            _RehabRepo = RehabRepo;
            _UserManager = UserManager;
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
            model.PostedBy = _UserManager.GetUserName(User);
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

        public class InjuryLogsInputModel
        {
            public List<InjuryLogModel> logModels {get; set;}
            public int ID;
        }
        public async Task<IActionResult> InjuryLogs(int id)
        {
            InjuryLogsInputModel model = new InjuryLogsInputModel();
            List<InjuryLogModel> a = await _InjuryLogRepo.GetList(id);
            model.logModels = new List<InjuryLogModel>();
            model.logModels.AddRange(a);
            model.ID = id;
            return View(model);
        }
        public class LogWithRehab{
            public InjuryLogModel log {get;set;}
            public RehabModel rehab {get;set;}
        }
        public IActionResult ViewLog(int id)
        {
            InjuryLogModel log = _InjuryLogRepo.Get(id);
            RehabModel rehab = _RehabRepo.Get(log.RehabID);
            LogWithRehab lr = new LogWithRehab();
            lr.log = log;
            lr.rehab = rehab;
            return View(lr);
        }
        public class InputInjuryLogModel : InjuryLogModel{
            public List<RehabModel> RehabOptions {get; set;}
        }
        public async Task<IActionResult> PostInjuryLog(int id)
        {
            InputInjuryLogModel model = new InputInjuryLogModel();
            model.InjuryID = id;
            model.PostedBy = _UserManager.GetUserName(User);
            
            List<RehabModel> options = await _RehabRepo.GetList();
            model.RehabOptions = options;
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult PostInjuryLog(InputInjuryLogModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }
            return Create((InjuryLogModel)model);
        }

        protected IActionResult Create(InjuryLogModel model)
        {
            _InjuryLogRepo.Save(model);
            return RedirectToAction("Index");
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
