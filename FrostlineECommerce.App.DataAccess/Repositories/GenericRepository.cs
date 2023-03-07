﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using FrostlineECommerce.App.DataAccess.Abstract;
using FrostlineECommerce.App.DataAccess.Concrete;

namespace FrostlineECommerce.App.DataAccess.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected Context c = new Context();

        public void Add(T entity)
        {
            c.Add(entity);
            c.SaveChanges();
        }

        public void Delete(T entity)
        {
            c.Remove(entity);
            c.SaveChanges();
        }

        public List<T> GetAll()
        {
            return c.Set<T>().ToList();
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter)
        {
            return c.Set<T>().Where(filter).ToList();
        }

        public T GetById(int id)
        {
            return c.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            c.Update(entity);
            c.SaveChanges();
        }
    }
}
