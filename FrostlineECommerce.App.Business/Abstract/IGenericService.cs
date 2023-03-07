using System;
using System.Collections.Generic;

namespace FrostlineECommerce.App.Business.Abstract
{
    public interface IGenericService<T>
    {
        void TAdd(T entity);
        void TDelete(T entity);
        void TUpdate(T entity);
        List<T> TGetAll();
        T TGetById(int id);
    }
}
