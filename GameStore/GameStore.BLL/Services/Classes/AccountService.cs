using GameStore.BLL.Models.BusinessModels;
using GameStore.BLL.Services.Interfaces;
using GameStore.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.BLL.Services.Classes
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        
        public AccountService(UserManager<User> _userManager, SignInManager<User> _signInManager)
        {
            userManager = _userManager;
            signInManager = _signInManager;
        }

        public void Dispose()
        {
            userManager.Dispose();
            signInManager.UserManager.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task<bool> UserNameExistsAsync(string Name)
        {
            return await userManager.FindByNameAsync(Name) is { };
        }

        public async Task<SignInResult> SignInAsync(LoginModel model)
        {
            
            return await signInManager.PasswordSignInAsync(
                await userManager.FindByNameAsync(model.UserName),
                model.Password,
                model.RemeberMe,
                false
                );
        }

        public async Task SignOutAsync()
        {
            await signInManager.SignOutAsync();
        }
    }
}
