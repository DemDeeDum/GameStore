using GameStore.DAL.Entities;
using GameStore.DAL.Repositories.Interfaces;
using GameStore.DAL.UnitOfWork.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.DAL.UnitOfWork.Classes
{
    public class UoW : IUoW
    {
        public IRepository<Game> Games { get; set; }
        public IRepository<Update> Updates { get; set; }

        public UoW(IRepository<Game> gameRepository, IRepository<Update> updateRepository)
        {
            Games = gameRepository;
            Updates = updateRepository; 
        }

        private void DisposeRepositories()
        {
            Games.Dispose();
            Updates.Dispose();
        }

        public void Dispose()
        {
            DisposeRepositories();
            GC.SuppressFinalize(this);
        }
    }   
}
