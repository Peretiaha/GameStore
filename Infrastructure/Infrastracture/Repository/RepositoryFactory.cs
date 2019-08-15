using System;
using System.Collections.Generic;
using System.Text;
using GameStore.DAL.Interfaces;
using System.Runtime.CompilerServices;
using Autofac;

namespace GameStore.DAL.Repository
{
   
    public class RepositoryFactory : IRepositoryFactory
    {
        private readonly ILifetimeScope lifetimeScope;

        public RepositoryFactory(ILifetimeScope lifetimeScope)
        {
            this.lifetimeScope = lifetimeScope;
        }

        public IRepository<T> GetRepository<T>()
            where T : class
        {
            return this.lifetimeScope.Resolve<IRepository<T>>();
        }

    }
}
