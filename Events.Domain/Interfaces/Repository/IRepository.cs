using Events.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Events.Domain.Interfaces
{
    public interface IRepository<T> : IDisposable where T : Entity
    {
        void Add(T obj);

        void Update(T obj);

        void Remove(Guid id);

        T GetById(Guid id);

        IEnumerable<T> GetAll();

        T GetElement(Expression<Func<T, bool>> where);

        IEnumerable<T> Find(Expression<Func<T, bool>> where);

        IEnumerable<TResult> GetElementsByExpression<TResult>(Expression<Func<T, TResult>> selector, Expression<Func<T, bool>> where, string includes) where TResult : class;

        int SaveChanges();
    }
}
