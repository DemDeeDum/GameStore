using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using GameStore.DAL.Entities;
using GameStore.DAL.Repositories.Interfaces;
using System.Runtime.CompilerServices;
using Microsoft.Data.SqlClient;

namespace GameStore.DAL.ApplicationContext.Classes
{
    public class GameStoreContext : IdentityDbContext<User>
    {
        //Default syntax using services.AddDbContext 
        public GameStoreContext(DbContextOptions<GameStoreContext> options) : base(options) { }


        //Is used for creating migrations because there is no middleware in DAL to create a context
        public GameStoreContext() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(LocalDb)\\MSSQLLocalDB;Database=GameStoreDB;Trusted_Connection=True;");
        }

        //Tables
        public DbSet<Game> Games { get; set; }
        public DbSet<Update> Updates { get; set; }


        //Seed
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var adminUserId = Guid.NewGuid(); 
            var adminRoleGuId = Guid.NewGuid();

            builder.Entity<IdentityRole>().HasData(new IdentityRole()
            {
                Id = adminRoleGuId.ToString(),
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            builder.Entity<User>().HasData(new User()
            {
                Id = adminUserId.ToString(),
                UserName = "MainAdmin",
                NormalizedUserName = "MAINADMIN",
                Email = "my@email.com",
                NormalizedEmail = "MY@EMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<User>().HashPassword(null, "Ddee12@"),
                SecurityStamp = string.Empty
            });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = adminRoleGuId.ToString(),
                UserId = adminUserId.ToString()
            });

        }
    }
}
