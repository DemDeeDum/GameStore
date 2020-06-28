using GameStore.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;

namespace GameStore.DAL.Repositories.Interfaces
{
    public interface IRepository<TEntity> : IDisposable
        where TEntity : BaseEntity
    {
        public IQueryable<TEntity> GetAll();
        public TEntity GetOne(Guid id);
        public void Save(TEntity item);
        public void Delete(Guid id); 
    }
}
