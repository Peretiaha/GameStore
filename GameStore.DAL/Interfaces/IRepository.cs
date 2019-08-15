namespace GameStore.DAL.Interfaces
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using GameStoreModel.Models;

    public interface IRepository<T>
    {
        IEnumerable<T> GetMany(Expression<Func<T, bool>> filter = null, Expression<Func<T, object>> orderby=null);

        T GetSingle(Expression<Func<T, bool>> func);

        void Insert(T entity);

        void Edit(T entity);

        void Delete(T entity);
        
    }
}
