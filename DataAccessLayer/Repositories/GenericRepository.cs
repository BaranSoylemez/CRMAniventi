using DataAccessLayer.Concrete;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        Context c = new Context();
        DbSet<T> _object;
        public GenericRepository()
        {
            _object = c.Set<T>();
        }   
        public void Add(T item)
        {
            var addedentity = c.Entry(item);
            addedentity.State = EntityState.Added;
            c.SaveChanges();
        }

        public List<T> ConditionalList(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Delete(T item)
        {
            var deletedentity = c.Entry(item);
            deletedentity.State = EntityState.Deleted;
            c.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter);
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public void Update(T item)
        {
            var updatedentity = c.Entry(item);
            updatedentity.State = EntityState.Modified;
            c.SaveChanges();
        }
    }
}
