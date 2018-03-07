using System.Collections.Generic;
using System.Linq;

namespace DAL.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IReadOnlyCollection<T> Entities { get; }


        void Remove(T entity);


        void Add(T entity);


        void Update(T entity);


        T GetById(int id);

    }
}