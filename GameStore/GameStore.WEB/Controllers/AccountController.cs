using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameStore.WEB.ViewComponents;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using GameStore.BLL.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using AutoMapper;
using GameStore.BLL.Models.BusinessModels;
using GameStore.BLL.Services.Classes;

namespace GameStore.WEB.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly IAccountService accountService;
        private readonly IMapper mapper;

        public AccountController(
            IMapper _mapper,
            SignInManager<IdentityUser> _signInManager,
            UserManager<IdentityUser> _userManager
            )
        {
            accountService = new AccountService(_userManager, _signInManager);
            mapper = _mapper;
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Login(string returnURL)
        {
            ViewBag.ReturnURL = returnURL;
            return View(new LoginViewModel());
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model, string returnURL)
        {
            if(ModelState.IsValid )
            { 
                if(await accountService.UserNameExistsAsync(model.UserName))
                {
                    await accountService.SignOutAsync();
                    Microsoft.AspNetCore.Identity.SignInResult result =
                        await accountService.SignInAsync(mapper.Map<LoginModel>(model));
                    if(result.Succeeded)
                    {
                        return Redirect(returnURL ?? "/");
                    }
                }
                ModelState.AddModelError(nameof(LoginViewModel.UserName), "Login or password is not correct");
            }
            return View(model);
        }

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await accountService.SignOutAsync();
            return RedirectToAction("Main", "Public");
        }
    }
}
