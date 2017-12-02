using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IRepository<TEntity, TKey>
       where TEntity : class
       where TKey : class
    {
        TEntity Get(TKey Key);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> Predicate);
        void Add(TEntity Entity);
        void AddRange(IEnumerable<TEntity> Entities);
        void Remove(TEntity Entity);
        void RemoveRange(IEnumerable<TEntity> Entities);
    }
}
