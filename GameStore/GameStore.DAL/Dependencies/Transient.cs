using GameStore.DAL.Entities;
using GameStore.DAL.Repositories.Classes;
using GameStore.DAL.Repositories.Interfaces;
using GameStore.DAL.UnitOfWork.Classes;
using GameStore.DAL.UnitOfWork.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace GameStore.DAL.Dependencies
{
    public partial class DALDependencies
    {
        private void SetUpTransientDependencies(IServiceCollection services)
        {
            //services.AddTransient<SomeInterface, SomeImplement>();
            services.AddTransient<IRepository<Game>, Repository<Game>>();
            services.AddTransient<IRepository<Update>, Repository<Update>>();
            services.AddTransient<IUoW, UoW>();
        }
    }
}
