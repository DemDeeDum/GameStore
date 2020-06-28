using GameStore.BLL.Models.BusinessModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.BLL.Services.Interfaces
{
    public interface IAccountService : IDisposable
    {
        Task<SignInResult> SignInAsync(LoginModel model);
        Task SignOutAsync();
        Task<bool> UserNameExistsAsync(string Name);
    }
}
