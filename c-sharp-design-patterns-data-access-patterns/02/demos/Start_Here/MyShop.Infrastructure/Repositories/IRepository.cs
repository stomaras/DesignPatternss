using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MyShop.Infrastructure.Repositories
{
    public interface IRepository<T>
    {
        T Add(T entity);
        T Update(T entity);
        T Get(Guid id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        // Find(cutomer => customer.Age > 20);
        void SaveChanges();
    }
}
