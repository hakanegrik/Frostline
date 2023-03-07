using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace FrostlineECommerce.App.DataAccess.Abstract
{
    public interface IGenericRepository<T> where T : class
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        List<T> GetAll();
        T GetById(int id);

        List<T> GetAll(Expression<Func<T, bool>> filter);
    }
}
