using System;
using Events.Domain.Interfaces;
using Events.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using Events.Domain.Entities;

namespace Events.Infra.Data.Repository
{
    public abstract class Repository<T> : IRepository<T> where T : Entity
    {
        protected EventContext Db;
        protected DbSet<T> DbSet;

        protected Repository(EventContext context)
        {
            Db = context;
            DbSet = Db.Set<T>();
        }

        public virtual void Add(T obj)
        {
            DbSet.Add(obj);
        }

        public virtual void Update(T obj)
        {
            DbSet.Update(obj);
        }

        public virtual void Remove(Guid id)
        {
            DbSet.Remove(DbSet.Find(id));
        }

        public virtual T GetById(Guid id)
        {
            return DbSet.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }

        public virtual IEnumerable<T> Find(Expression<Func<T, bool>> where)
        {
            return DbSet.AsNoTracking().Where(where);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return DbSet.ToList();
        }

        public virtual T GetElement(Expression<Func<T, bool>> where)
        {
            return DbSet.AsNoTracking().FirstOrDefault(where);
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
