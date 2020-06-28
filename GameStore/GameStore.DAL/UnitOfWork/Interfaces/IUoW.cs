using GameStore.DAL.Entities;
using GameStore.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.DAL.UnitOfWork.Interfaces
{
    public interface IUoW : IDisposable
    {
        public IRepository<Game> Games { get; set; }
        public IRepository<Update> Updates { get; set; }
    }
}
