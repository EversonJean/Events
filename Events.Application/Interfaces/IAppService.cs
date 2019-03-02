using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Events.Application.Interfaces
{
    public interface IAppService<T>: IDisposable where T : class
    {
        void Add(T obj);

        void Update(T obj);

        void Remove(Guid id);

        T GetById(Guid id);

        IEnumerable<T> GetAll();

        T GetElement(Expression<Func<T, bool>> where);

        IEnumerable<T> Find(Expression<Func<T, bool>> where);
    }
}
