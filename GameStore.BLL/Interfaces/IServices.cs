
namespace GameStoreModel.Interfaces
{
    public interface IServices<in TEntity> where TEntity : class
    {
        void Create(TEntity entity);

        void Edit(TEntity entity);

        void Delete(TEntity entity);
    }
}
