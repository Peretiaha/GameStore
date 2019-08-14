
namespace GameStore.DAL.Repository
{
    using GameStore.DAL.Interfaces;
    using GameStoreModel;
    using GameStoreModel.Models;

    public class GameRepository : Repository<Game>, IGameRepository
    {
        public GameRepository(GameStoreDb gameStoreDb)
            : base(gameStoreDb)
        {
        }
    }
}
