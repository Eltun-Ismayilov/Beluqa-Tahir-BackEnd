using BeluqaTahir.Domain.Model.DataContexts;
using BeluqaTahir.Domain.Model.Entity.Membership;
using BeluqaTahir.Domain.Model.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeluqaTahir.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class UsersController : Controller
    {
        private readonly UserManager<BeluqaUser> userManager;
        private readonly BeluqaTahirDbContext db;

        public UsersController(UserManager<BeluqaUser> userManager, BeluqaTahirDbContext db)
        {

            this.userManager = userManager;
            this.db = db;

        }
        public async Task<IActionResult> Index()
        {
            List<BeluqaUser> riodeUsers = userManager.Users.ToList();


            List<UserVM> users = new List<UserVM>();
            foreach (BeluqaUser item in riodeUsers)
            {
                UserVM vm = new UserVM
                {
                    Id = item.Id,
                    Email = item.Email,
                    UserName = item.UserName,
                    Activated = item.Activates,
                    Role = ((await userManager.GetRolesAsync(item))[0])

                };
                users.Add(vm);
            }
            return View(users);

        }

        public async Task<IActionResult> Activated(string id)
        {

            if (id == null)
            {
                return NotFound();
            }

            BeluqaUser user = await userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();

            }

            return View(user);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Activated(string id, bool Activated)
        {

            if (id == null)
            {
                return NotFound();
            }

            BeluqaUser user = await userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();

            }


            user.Activates = Activated;
            await db.SaveChangesAsync();
            return RedirectToAction("index");


        }

        //Islemir heleki
        public async Task<IActionResult> ChangRole(string id)
        {

            if (id == null)
            {
                return NotFound();
            }

            BeluqaUser user = await userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();

            }

            UserVM vm = new UserVM
            {
                Id = user.Id,
                Email = user.Email,
                UserName = user.UserName,
                Activated = user.Activates,
                Role = ((await userManager.GetRolesAsync(user))[0]),
                Roles = new List<string> { "SuperAdmin", "User" }
            };

            return null;
        }


        public async Task<IActionResult> RessetPassword(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            BeluqaUser riode = await userManager.FindByIdAsync(id);
            if (riode == null)
            {
                return NotFound();

            }
            return View(riode);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RessetPassword(string id, string newPassword)
        {
            if (id == null)
            {
                return NotFound();
            }
            BeluqaUser user = await userManager.FindByIdAsync(id);

            if (user == null)
            {
                return NotFound();

            }

            string token = await userManager.GeneratePasswordResetTokenAsync(user);
            var identityResult = await userManager.ResetPasswordAsync(user, token, newPassword);
            if (!identityResult.Succeeded)
            {
                foreach (var item in identityResult.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
                return View(user);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
