using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.DAL.Interfaces
{
    public interface IRepositoryFactory
    {
        IRepository<T> GetRepository<T>()
            where T : class;
    }
}
