using GameStore.BLL.Services.Classes;
using GameStore.BLL.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace GameStore.WEB.Dependencies
{
    public partial class WEBDependencies
    {
        private void SetUpScopedDependencies(IServiceCollection services)
        {
            //services.AddScoped<SomeInterface, SomeImplement>();
            services.AddScoped<IAccountService, AccountService>();
        }
    }
}
