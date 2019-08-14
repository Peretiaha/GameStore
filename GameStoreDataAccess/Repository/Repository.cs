using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using GameStoreModel;
using GameStoreModel.Interfaces;


namespace GameStore.DAL.Repository
{
    using GameStore.DAL.Interfaces;

    public abstract class Repository<T> : IRepository<T> where T : class
    {
        protected GameStoreDb GameStoreDb { get; set; }

        public Repository(GameStoreDb gameStoreDb)
        {
            this.GameStoreDb = gameStoreDb;
        }


        public void Create(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(T entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> FindAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
