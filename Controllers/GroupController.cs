using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Lab8.Areas.Identity.Data;
using Lab8.Models;
using Repositories.Group;
using Microsoft.Extensions.Options;

namespace Lab8.Controllers
{
    [Authorize]
    public class GroupController : Controller
    {
        private readonly object groupLock = new object();

        private IGroupRepository _GroupRepo;
        private Lab8Settings _Settings;
        private RoleManager<IdentityRole> _RoleManager;
        private UserManager<Lab8Model> _UserManager;
        public GroupController(RoleManager<IdentityRole> roleManager, IOptionsSnapshot<Lab8Settings> settings, 
        UserManager<Lab8Model> userManager, IGroupRepository groupRepo)
        {
            _RoleManager = roleManager;
            _UserManager = userManager;
            _GroupRepo = groupRepo;
            _Settings = settings.Value;
        }
        public async Task<IActionResult> Index()
        {
            GroupModel group= new GroupModel();;
            var user = await _UserManager.GetUserAsync(User);

            lock (groupLock)
            {
                if (user.GroupID == 0)
                { 
                    group.Name = _Settings.EmptyGroupName;
                    group.Description = _Settings.EmptyGroupDescription;
                }
                else
                    group = _GroupRepo.Get(user.GroupID);
            }
            return View(group);
        }

        public async Task<IActionResult> JoinGroup()
        {
            List<GroupModel> groups = await _GroupRepo.GetList();
            return View(groups);
        }
        
        public IActionResult View(int id)
        {
            GroupModel a = _GroupRepo.Get(id);
            return View(a);
        }
        public  IActionResult CreateGroup(){
            GroupModel group = new GroupModel();
            return View(group);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateGroup(GroupModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            Lab8Model user = _UserManager.FindByNameAsync(_UserManager.GetUserName(User)).Result;
            IdentityResult result = _UserManager.AddToRoleAsync(user, "Admin").Result;
            if (!result.Succeeded)
            {
                throw new Exception(result.Errors.Select(e => e.Description).Aggregate((a, b) => a + "," + b));
            }
            return  Create(model); 
        }

        protected IActionResult Create(GroupModel model)
        {
            model.DateCreated = DateTime.Now;
            model.NumberOfMembers = 1;            
            _GroupRepo.Save(model);
            return RedirectToAction("Index");
        }
    }
}
