using GameStore.DAL.Dependencies;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.BLL.Dependencies
{
    public partial class BLLDependencies
    {
        public BLLDependencies(IServiceCollection services, Dictionary<string,string> ConnectionStrings)
        {
            SetUpTransientDependencies(services);
            SetUpSingletonDependencies(services);
            SetUpScopedDependencies(services);
            new DALDependencies(services, ConnectionStrings);
        }
    }
}
