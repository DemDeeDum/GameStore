using GameStore.DAL.Entities;
using GameStore.DAL.Repositories.Classes;
using GameStore.DAL.Repositories.Interfaces;
using GameStore.DAL.UnitOfWork.Classes;
using GameStore.DAL.UnitOfWork.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace GameStore.BLL.Dependencies
{
    public partial class BLLDependencies
    {
        private void SetUpTransientDependencies(IServiceCollection services)
        {
            //services.AddTransient<SomeInterface, SomeImplement>();
        }
    }
}
