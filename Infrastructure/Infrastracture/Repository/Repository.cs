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
        private readonly GameStoreDb GameStoreDb;

        private readonly DbSet<T> _set;

        public Repository(GameStoreDb gameStoreDb)
        {
            this.GameStoreDb = gameStoreDb;
        }


        public IEnumerable<T> GetMany(Expression<Func<T,bool>> filter = null, Expression<Func<T,object>> orderby = null)
        {
            return this._set.AsQueryable()
                .Where(filter).OrderBy(orderby).ToList();
        }

        public T GetSingle(Expression<Func<T, bool>> filter = null)
        {
            var entity = this._set.FirstOrDefault(filter);
            return entity;
        }

        public IEnumerable<T> GetMany()
        {
            throw new NotImplementedException();
        }

        public T GetSingle()
        {
            throw new NotImplementedException();
        }

        public void Insert(T entity)
        {
            this._set.Add(entity);
        }

        public void Delete(T entity)
        {
            this._set.Remove(entity);
        }

        public void Edit(T entity)
        {
            this._set.Attach(entity);
            this.GameStoreDb.Entry(entity).State = EntityState.Modified;
        }

        public IEnumerable<T> FindAll()
        {
            return this._set.ToList();
        }



    }
}
