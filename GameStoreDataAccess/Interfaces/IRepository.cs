namespace GameStore.DLL.Interfaces
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;

    public interface IRepository<T>
    {
        IQueryable<T> FindAll();    // How will be sorted, add another methods!
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);

        void Create(T entity);

        void Edit(T entity);

        void Delete(T entity);
    }
}
