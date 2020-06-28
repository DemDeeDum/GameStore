using Microsoft.Extensions.DependencyInjection;

namespace GameStore.BLL.Dependencies
{
    public partial class BLLDependencies
    {
        private void SetUpSingletonDependencies(IServiceCollection services)
        {
            //services.AddSingleton<SomeInterface, SomeImplement>();
        }
    }
}
