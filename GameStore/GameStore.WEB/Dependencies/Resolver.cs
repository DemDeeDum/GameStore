using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore.WEB.Dependencies
{
    public partial class WEBDependencies
    {
        public WEBDependencies(IServiceCollection services)
        {
            SetUpScopedDependencies(services);
            SetUpSingletonDependencies(services);
            SetUpTransientDependencies(services);
        }
    }
}
