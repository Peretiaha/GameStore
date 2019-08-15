using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Infrastracture
{
    using GameStore.DAL.Interfaces;

    using GameStoreModel;

    public class UnitOfWork : IUnitOfWork
    {
        private readonly GameStoreDb gameStoreDb;

        private readonly IRepositoryFactory repositoryFactory;

        public UnitOfWork(GameStoreDb gameStoreDb, IRepositoryFactory repositoryFactory)
        {
            this.gameStoreDb = gameStoreDb;
            this.repositoryFactory = repositoryFactory;
        }

        public void Commit()
        {
            this.gameStoreDb.SaveChanges();
        }

        public IRepository<T> GetRepository<T>() where T : class
        {
            return repositoryFactory.GetRepository<T>();
        }

    }
}
