
namespace GameStore.DAL.Repository
{
    using GameStore.DAL.Interfaces;
    using GameStoreModel;
    using GameStoreModel.Models;

    public class PlatformTypeRepository : Repository<PlatformType>, IPlatformTypeRepository
    {
        public PlatformTypeRepository(GameStoreDb gameStoreDb)
            : base(gameStoreDb)
        {
        }
    }
}
