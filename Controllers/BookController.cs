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
using Book.Repositories;
using Microsoft.Extensions.Caching.Memory;

namespace Lab8.Controllers
{
    [Authorize (Roles="Booker")]
    public class BookController : Controller
    {
        private IBookRepository _BookRepo;
        private Lab8Settings _Settings;
        private IMemoryCache _Cache;
         public BookController(IMemoryCache cache,IOptionsSnapshot<Lab8Settings> settings, IBookRepository BookRepo)
        {
            _Settings = settings.Value;
            _Cache = cache;
            _BookRepo = BookRepo; 
        }
        public async Task<IActionResult> Index()
        {
            List<BookModel> BookList = new List<BookModel>();
            BookList.AddRange(await  _BookRepo.GetList());
            return View(BookList);
        }

        [HttpGet]
        public IActionResult PostBlog()
        {
            BookModel model = new BookModel();
            model.BTitle = _Settings.DefaultName;
            model.BRating = _Settings.DefaultRating;
            model.PostedBy = _Settings.DefaultUser;
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult PostBlog(BookModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
                //return RedirectToAction("Index");

            }
            return Create(model);
        }

        protected IActionResult Create(BookModel model)
        {
            _BookRepo.Save(model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            BookModel Book = _BookRepo.Get(id);
            return View(Book);
        }
        public IActionResult View(int id)
        {
            BookModel a = _BookRepo.Get(id);
            return View(a);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _BookRepo.Delete(id);
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
