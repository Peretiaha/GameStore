
namespace GameStore.DAL.Repository
{
    using GameStore.DAL.Interfaces;

    using GameStoreModel;
    using GameStoreModel.Models;

    public class GenreRepository : Repository<Genre>, IGenreRepository
    {
        public GenreRepository(GameStoreDb gameStoreDb)
            : base(gameStoreDb)
        {
        }
    }
}
