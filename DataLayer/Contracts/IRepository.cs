using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Contracts
{
    public interface IRepository<T> where T : class
    {
        T GetById(object id);
        IQueryable<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(object id);
        void SaveChanges();
        void Load<TElement>(T entity, Expression<Func<T, ICollection<TElement>>> navigationProperty) where TElement : class;
        void Load<TElement>(T entity, Expression<Func<T, ICollection<TElement>>> navigationProperty, Expression<Func<TElement, bool>> predicate) where TElement : class;
    }
}
