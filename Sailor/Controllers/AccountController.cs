using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Sailor.Models;
using Sailor.Utilities;
using Sailor.ViewModels;

namespace Sailor.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _manager;
        private readonly SignInManager<AppUser> _signIn;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AccountController(UserManager<AppUser> manager,SignInManager<AppUser> signIn,RoleManager<IdentityRole> roleManager)
        {
           _manager = manager;
           _signIn = signIn;
           _roleManager = roleManager;
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> Register(RegisterVM register)
        {
            AppUser user = new AppUser
            {
                Firstname = register.Firstname,
                Lastname = register.Lastname,
                UserName = register.Username,
                Email = register.Email
            };

            if(register.Term == true)
            {
                IdentityResult result = await _manager.CreateAsync(user, register.Password);
                if (!result.Succeeded)
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    return View();
                }
            }
            else
            {
                ModelState.AddModelError("", "You cannot registration without our agree!");
                return View();
            }

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> Login(LoginVM login)
        {
            AppUser user = await _manager.FindByNameAsync(login.Username);

            Microsoft.AspNetCore.Identity.SignInResult result = await _signIn.PasswordSignInAsync(user, login.Password, false, false);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Incorrect password or password");
                return View();
            }

            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Logout()
        {
            await _signIn.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }
        public  IActionResult Show()
        {
            return Content(User.Identity.IsAuthenticated.ToString());
        }

        public async Task<IActionResult> Edit()
        {
            AppUser user = await _manager.FindByNameAsync(User.Identity.Name);

            EditUserVM editUser = new EditUserVM
            {
                Firstname = user.Firstname,
                Lastname = user.Lastname,
                Email = user.Email,
                Username = user.UserName
            };

            return View(editUser);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> Edit(EditUserVM editUser)
        {
            AppUser existed = await _manager.FindByNameAsync(User.Identity.Name);

            EditUserVM userVM = new EditUserVM
            {
                Firstname = editUser.Firstname,
                Lastname = editUser.Lastname,
                Username = editUser.Username
            };
            if (!ModelState.IsValid) return View(userVM);

            bool cases = editUser.Password == null && editUser.ConfirmPassword == null && editUser.CurrentPassword != null;

            if(editUser.Email == null || editUser.Email != existed.Email)
            {
                ModelState.AddModelError("", "Email can't changed");
                return View();
            }

            if (cases)
            {
                existed.Firstname = editUser.Firstname;
                existed.Lastname = editUser.Lastname;
                existed.UserName = editUser.Username;
                await _manager.UpdateAsync(existed);

            }
            else
            {
                existed.Firstname = editUser.Firstname;
                existed.Lastname = editUser.Lastname;
                existed.UserName = editUser.Username;

                IdentityResult result = await _manager.ChangePasswordAsync(existed, editUser.CurrentPassword, editUser.Password);

                if (!result.Succeeded)
                {
                    foreach(IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                        
                    }
                    return View();
                }
            }

            return RedirectToAction("Index", "Home");
        }

        public async Task CreateRoles()
        {
            await _roleManager.CreateAsync(new IdentityRole { Name = Roles.Member.ToString() });
            await _roleManager.CreateAsync(new IdentityRole { Name = Roles.Admin.ToString() });
            await _roleManager.CreateAsync(new IdentityRole { Name = Roles.SuperAdmin.ToString() });
        }
    }
}
