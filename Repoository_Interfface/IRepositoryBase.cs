using System.Linq.Expressions;

namespace Repoository_Interfface
{
    public interface IRepositoryBase<T> where T : class
    {
        void Add(T entity);
        T Get(Expression<Func<T, bool>> where);
        T Get(int id);
        T Get(decimal id);
        T Get(float id);
        T Get(string id);
        void Update(T entity);
        void Delete(T entity);
        void Delete(Expression<Func<T, bool>> where);
        IQueryable<T> AsQueryable();
        IEnumerable<T> GetAll();
        void Commit();
        void Save();
        void Rollback();
        void Dispose();
        public int GetMaxPK(string pkPropertyName);
    }
}
