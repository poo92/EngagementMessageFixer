using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Contracts;
using DataLayer.DBContext;

namespace DataLayer.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        internal Identity DbContext;
        internal IDbSet<T> DbSet;

        public BaseRepository()
        {        
            this.DbContext = new Identity();
            this.DbSet = this.DbContext.Set<T>();
        }

        //Be careful
        public virtual IQueryable<T> GetAll()
        {
            return DbSet;
        }

        public virtual T GetById(object id)
        {
            return DbSet.Find(id);
        }

        public virtual IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return DbSet.Where(predicate);
        }

        public virtual void Add(T entity)
        {
            DbSet.Add(entity);
            DbContext.SetAdd(entity);
        }

        public virtual void Delete(object id)
        {

            var entity = GetById(id);
            if (entity != null)
            {
                Delete(entity);
            }

        }

        public virtual void Delete(T entity)
        {
            DbSet.Remove(entity);
        }

        public virtual void Update(T entity)
        {
            DbSet.Attach(entity);
            DbContext.SetModified(entity);
        }

        public virtual void SaveChanges()
        {
            DbContext.SaveChanges();
        }

        public void Load<TElement>(T entity, Expression<Func<T, ICollection<TElement>>> navigationProperty) where TElement : class
        {
            if (!DbContext.Entry(entity).Collection(navigationProperty).IsLoaded)
            {
                DbContext.Entry(entity).Collection(navigationProperty).Load();
            }
        }

        public void Load<TElement>(T entity, Expression<Func<T, ICollection<TElement>>> navigationProperty, Expression<Func<TElement, bool>> predicate) where TElement : class
        {
            if (!DbContext.Entry(entity).Collection(navigationProperty).IsLoaded)
            {
                DbContext.Entry(entity).Collection(navigationProperty).Query().Where(predicate).Load();
            }
        }
    }
}
