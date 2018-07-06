using IEC.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IEC.DAL.Repository
{
    public interface IRepository<TEntity> : IDisposable where TEntity : BaseEntity
    {
        TEntity Get(int ID);
        TEntity Get(Expression<Func<TEntity, bool>> predicate);

        IQueryable<TEntity> GetAll();

        IQueryable<TEntity> GetRange(Expression<Func<TEntity, bool>> predicate);

        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);

        void Remove(TEntity entity);
        void Remove(int entityID);
    }
}
