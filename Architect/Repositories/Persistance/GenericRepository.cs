using DAL;
using Entities;
using Repositories.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Persistance
{
    public class GenericRepository<T> : IGenericRepository<T> where T : Vehicle
    {
        public MainDBContext db;
        public DbSet<T> table;

        public GenericRepository(MainDBContext context)
        {
            db = context;
            table = db.Set<T>();
        }
        public void Add(T obj)
        {
            table.Attach(obj);
            db.Entry(obj).State = EntityState.Added;
        }

        public void Delete(object id)
        {
            var obj = table.Find(id);
            table.Attach(obj);
            db.Entry(obj).State = EntityState.Deleted;
        }

        public void DeleteAll()
        {
            var objects = GetAll();
            table.RemoveRange(objects);
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public T GetById(object id)
        {
            T obj = table.Find(id);
            return obj;
        }


        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(T obj)
        {
            table.Attach(obj);
            db.Entry(obj).State = EntityState.Modified;
        }
    }
}
