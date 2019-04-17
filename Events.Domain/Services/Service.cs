using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Events.Domain.Entities;
using Events.Domain.Interfaces;

namespace Events.Domain.Services
{
    public abstract class Service<T, R> : IService<T> where T : Entity where R : IRepository<T>
    {
        protected readonly R _repository;

        protected Service(R repository)
        {
            _repository = repository;
        }

        public abstract bool IsValid(T obj);

        public void Add(T obj)
        {
            _repository.Add(obj);
        }

        public void Update(T obj)
        {
            _repository.Update(obj);
        }

        public void Remove(Guid id)
        {
            _repository.Remove(id);
        }

        public T GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public T GetElement(Expression<Func<T, bool>> where)
        {
            return _repository.GetElement(where);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> where)
        {
            return _repository.Find(where);
        }

        public IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }

        public IEnumerable<TResult> GetElementsByExpression<TResult>(Expression<Func<T, TResult>> selector,
            Expression<Func<T, bool>> where = null, string includes = null) where TResult : class
        {
            return _repository.GetElementsByExpression(selector, where, includes);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }
    }
}
