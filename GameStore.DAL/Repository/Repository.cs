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

    using GameStoreModel.Models;

    public abstract class Repository<T> : IRepository<T> where T : class
    {
        private  readonly GameStoreDb GameStoreDb;

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

        }
}
