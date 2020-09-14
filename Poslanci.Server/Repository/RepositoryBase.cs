using Entities.Models;
using Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected PoliticsContext PoliticsContext { get; set; }

        public RepositoryBase(PoliticsContext politicsContext)
        {
            PoliticsContext = politicsContext;
        }

        public IQueryable<T> FindAll()
        {
            return PoliticsContext.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return PoliticsContext.Set<T>()
                .Where(expression).AsNoTracking();
        }

        public void Create(T entity)
        {
            PoliticsContext.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            PoliticsContext.Set<T>().Remove(entity);
        }

        public void Update(T entity)
        {
            PoliticsContext.Set<T>().Update(entity);
        }
    }
}
