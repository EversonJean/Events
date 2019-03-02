using AutoMapper;
using Events.Application.Interfaces;
using Events.Domain.Entities;
using Events.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Events.Application.Services
{
    public abstract class AppService<T, E, S> : IAppService<E> where T : class where E : Entity where S : IService<E>
    {
        protected readonly S _service;
        protected readonly IMapper _mapper;

        public AppService(S service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public void Add(E obj)
        {
            _service.Add(obj);
        }

        public void Update(E obj)
        {
            _service.Update(obj);
        }

        public void Remove(Guid id)
        {
            _service.Remove(id);
        }

        public IEnumerable<E> Find(Expression<Func<E, bool>> where)
        {
            return _service.Find(where);
        }

        public IEnumerable<E> GetAll()
        {
            return _service.GetAll();
        }

        public E GetById(Guid id)
        {
            return _service.GetById(id);
        }

        public E GetElement(Expression<Func<E, bool>> where)
        {
            return _service.GetElement(where);
        }

        public void Dispose()
        {
            _service.Dispose();
        }
    }
}
