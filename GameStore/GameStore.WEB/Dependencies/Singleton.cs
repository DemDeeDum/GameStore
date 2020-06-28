using AutoMapper;
using GameStore.WEB.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace GameStore.WEB.Dependencies
{
    public partial class WEBDependencies
    {
        private void SetUpSingletonDependencies(IServiceCollection services)
        {
            //services.AddSingleton<SomeInterface, SomeImplement>();

            services.AddSingleton(new MapperConfiguration(mc =>
            {
                mc.AddProfile(new WebMapper());
            })
                .CreateMapper());
        }
    }
}
