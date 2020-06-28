using GameStore.DAL.ApplicationContext.Classes;
using GameStore.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.DAL.Dependencies
{
    public partial class DALDependencies
    {
        private void SetUpDbContext(IServiceCollection services, Dictionary<string,string> ConnectionStrings)
        {
            //services.AddDbContext<SomeContext>(x => x.UseSqlServer(SomeString));
            services.AddDbContext<GameStoreContext>(x => x.UseSqlServer(ConnectionStrings["GameStoreContext"]));
        }

        private void IdentitySettings(IServiceCollection services)
        {
            services.AddIdentityCore<User>(opts =>
                {
                    opts.User.RequireUniqueEmail = true;
                    opts.Password.RequiredLength = 6;
                    opts.Password.RequireNonAlphanumeric = true;
                    opts.Password.RequireDigit = true;
                    opts.Password.RequireLowercase = true;
                    opts.Password.RequireUppercase = true;
                })
            .AddEntityFrameworkStores<GameStoreContext>();
        }
    }
}
    