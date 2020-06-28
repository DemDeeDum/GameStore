using GameStore.DAL.ApplicationContext.Classes;
using GameStore.DAL.Entities;
using GameStore.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameStore.DAL.Repositories.Classes
{
    public class Repository<TEntity>: IRepository<TEntity>
        where TEntity : BaseEntity
    {
        private readonly GameStoreContext context;
        
        public Repository(GameStoreContext context)
        {
            this.context = context;
        }
    
        public IQueryable<TEntity> GetAll()
        {
            return context.Set<TEntity>();
        }

        public TEntity GetOne(Guid id)
        {
            return (TEntity)context.Find(typeof(TEntity), id);
        }

        public void Save(TEntity item)
        {
            context.Entry(item).State = item.Id == default ? EntityState.Added : EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var item = GetOne(id);
            item.IsDeleted = true;
            Save(item);
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
