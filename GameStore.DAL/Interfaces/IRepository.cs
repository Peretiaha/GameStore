namespace GameStore.DAL.Interfaces
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;

    using GameStoreModel.Models;

    public interface IRepository<T>
    {
        IQueryable<T> FindAll();    // How will be sorted, add another methods!

        void Create(T entity);

        void Edit(T entity);

        void Delete(T entity);
        
    }
}
