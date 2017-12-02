using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public abstract class Repository<TEntity, TKey> : IRepository<TEntity, TKey>
         where TEntity : class
         where TKey : class
    {
        protected readonly DbContext context;
        public Repository(DbContext context)
        {
            this.context = context;
        }
        public void Add(TEntity Entity)
        {
            context.Set<TEntity>().Add(Entity);
        }

        public void AddRange(IEnumerable<TEntity> Entities)
        {
            context.Set<TEntity>().AddRange(Entities);
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> Predicate)
        {
            return context.Set<TEntity>().Where(Predicate).ToList();
        }

        public TEntity Get(TKey Key)
        {
            return context.Set<TEntity>().Find(Key);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return context.Set<TEntity>().ToList();
        }

        public void Remove(TEntity Entity)
        {
            context.Set<TEntity>().Remove(Entity);
        }

        public void RemoveRange(IEnumerable<TEntity> Entities)
        {
            context.Set<TEntity>().RemoveRange(Entities);
        }

        public void Update(TEntity Entity)
        {
            context.Entry(Entity).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
