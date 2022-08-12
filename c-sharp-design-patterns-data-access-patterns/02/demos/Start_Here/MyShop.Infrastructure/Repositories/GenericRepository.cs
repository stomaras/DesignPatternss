using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace MyShop.Infrastructure.Repositories
{
    /*
     * The consumer controller willnow have a generic way to work with data in the database
     * without knowing about Entity Framework
     * Consumer dont' have t worry 
     * The sub classes of our generic repository can add custom behaviour to each of the methods before data 
     * is passed to the database or returned to the caller
     * 
     */
    public abstract class GenericRepository<T> : IRepository<T> where T : class
    {

        // We need to know about shopping context with ependecny injection

        protected ShoppingContext context;

        public GenericRepository(ShoppingContext context)
        {
            this.context = context;
        }
        public virtual T Add(T entity)
        {
            return context.Add(entity).Entity;
        }

        public virtual IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return context.Set<T>().AsQueryable().Where(predicate).ToList();
        }

        public virtual T Get(Guid id)
        {
            return context.Find<T>(id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public virtual void SaveChanges()
        {
            context.SaveChanges();
        }

        public virtual T Update(T entity)
        {
            return context.Update(entity).Entity;
        }
    }
}
