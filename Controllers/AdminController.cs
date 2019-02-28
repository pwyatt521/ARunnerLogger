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

namespace Lab8.Controllers
{
    [Authorize(Roles = "Admin")]
    //[Authorize]
    public class AdminController : Controller
    {

        private IGroupRepository _GroupRepo;
        private RoleManager<IdentityRole> _RoleManager;
        private UserManager<Lab8Model> _UserManager;
        public AdminController(RoleManager<IdentityRole> roleManager, UserManager<Lab8Model> userManager, IGroupRepository groupRepo)
        {
            _RoleManager = roleManager;
            _UserManager = userManager;
            _GroupRepo = groupRepo;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateRole(string RoleName)
        {
            IdentityRole role = new IdentityRole();
            role.Name = RoleName;
            IdentityResult result = _RoleManager.CreateAsync(role).Result;
            return RedirectToAction("Index");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteRole(string RoleName)
        {
            IdentityRole role = new IdentityRole();
            bool found = false;
            foreach (IdentityRole iRole in _RoleManager.Roles)
            {
                if (RoleName == iRole.Name){
                    found = true;
                    role = iRole;
                }
            }
            if (!found) return RedirectToAction("Index");
            foreach(var user in _UserManager.GetUsersInRoleAsync(role.Name).Result){
                IdentityResult userResult = _UserManager.RemoveFromRoleAsync(user, RoleName).Result;
                if (!userResult.Succeeded)
                {
                    throw new Exception(userResult.Errors.Select(e => e.Description).Aggregate((a, b) => a + "," + b));
                }
            }
            IdentityResult result = _RoleManager.DeleteAsync(role).Result;
            if (!result.Succeeded)
            {
                throw new Exception(result.Errors.Select(e => e.Description).Aggregate((a, b) => a + "," + b));

            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteUser(string Email)
        {
            Lab8Model user = _UserManager.FindByEmailAsync(Email).Result;

            IdentityResult result = _UserManager.DeleteAsync(user).Result;
            //Check the status of the result
            if (!result.Succeeded)
            {
                throw new Exception(result.Errors.Select(e => e.Description).Aggregate((a, b) => a + "," + b));

            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddUserToRole(string Email, string RoleName)
        {
            Lab8Model user = _UserManager.FindByEmailAsync(Email).Result;
            IdentityResult result = _UserManager.AddToRoleAsync(user, RoleName).Result;
            //Check the status of the result
            if (!result.Succeeded)
            {
                throw new Exception(result.Errors.Select(e => e.Description).Aggregate((a, b) => a + "," + b));
            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> EditGroup(){
            var user = await _UserManager.GetUserAsync(User);
            GroupModel group = _GroupRepo.Get(user.GroupID);
            return View(group);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditGroup(GroupModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            return Update(model);
        }

        protected IActionResult Update(GroupModel model)
        {
            _GroupRepo.Update(model);
            return RedirectToAction("Index");
        }
    }
}
