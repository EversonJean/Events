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

        void Remove(Guid Id);

        T GetById(Guid Id);

        IEnumerable<T> GetAll();

        T GetElement(Expression<Func<T, bool>> where);

        IEnumerable<T> Find(Expression<Func<T, bool>> where);

        int SaveChanges();
    }
}
