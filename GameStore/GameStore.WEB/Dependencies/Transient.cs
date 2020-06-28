using Microsoft.Extensions.DependencyInjection;

namespace GameStore.WEB.Dependencies
{
    public partial class WEBDependencies
    {
        private void SetUpTransientDependencies(IServiceCollection services)
        {
            //services.AddTransient<SomeInterface, SomeImplement>();
        }
    }
}
