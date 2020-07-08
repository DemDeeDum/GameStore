using GameStore.DAL.ApplicationContext.Classes;
using GameStore.DAL.Entities;
using GameStore.DAL.Migrations;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.DAL.Dependencies
{
    public partial class DALDependencies
    {
        public DALDependencies(IServiceCollection services, Dictionary<string,string> ConnectionStrings)
        {
            SetUpScopedDependencies(services);
            SetUpSingletonDependencies(services);
            SetUpDbContext(services, ConnectionStrings);
            IdentitySettings(services);
            SetUpTransientDependencies(services);
        }
    }
}
