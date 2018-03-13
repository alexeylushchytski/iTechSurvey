using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace iTechArt.Repositories.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void Remove(T entity);


        void Add(T entity);


        void Update(T entity);


        T GetById(int id);


        Task<T> GetByAsync(Expression<Func<T, bool>> predicate);


        Task<IReadOnlyCollection<T>>  GetAllAsync();


        Task<int> DeleteRange(IEnumerable<T> collection);
    }
}