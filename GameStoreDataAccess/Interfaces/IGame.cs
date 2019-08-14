
namespace GameStoreModel.Interfaces
{
    using System.Collections;

    using GameStoreModel.Models;

    public interface IGame<T> where T : class
    {
        void Add(T entity);

        void Edit(T entity);
        
        void Delete(T entity);

        void GetGameByKey(T entity);

        void AddComment(T entity);
    }
}
