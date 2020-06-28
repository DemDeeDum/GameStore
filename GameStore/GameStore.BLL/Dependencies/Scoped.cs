using GameStore.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace GameStore.BLL.Dependencies
{
    public partial class BLLDependencies
    {
        private void SetUpScopedDependencies(IServiceCollection services)
        {
            //services.AddScoped<SomeInterface, SomeImplement>();
            services.AddScoped<UserManager<User>>();
            services.AddScoped<SignInManager<User>>();
        }
    }
}
