using Microsoft.Extensions.DependencyInjection;

namespace GameStore.DAL.Dependencies
{
    public partial class DALDependencies
    {
        private void SetUpSingletonDependencies(IServiceCollection services)
        {
            //services.AddSingleton<SomeInterface, SomeImplement>();
        }
    }
}
