using System.Linq.Expressions;

namespace E_Commerce2.DAL
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        bool Any(Expression<Func<TEntity, bool>> predicate);
        TEntity Get(int id);
        TEntity GetBy(Expression<Func<TEntity, bool>> predicate);
        IEnumerable<TEntity> GetAllBy(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includeProperties);
        IEnumerable<TEntity> GetAll(params Expression<Func<TEntity, object>>[] includeProperties);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
