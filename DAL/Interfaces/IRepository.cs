using System;
using System.Linq;
using System.Linq.Expressions;

namespace DAL.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> Entities { get; }


        void Remove(T entity);


        void Add(T entity);


        void Update(T entity);


        T GetById(int id);

    }
}
