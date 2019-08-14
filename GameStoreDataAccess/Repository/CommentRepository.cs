namespace GameStore.DAL.Repository
{
    using GameStore.DAL.Interfaces;

    using GameStoreModel;
    using GameStoreModel.Models;

    public class CommentRepository : Repository<Comment>, ICommentRepository
    {

        public CommentRepository(GameStoreDb gameStoreDb)
            : base(gameStoreDb)
        {
        }

    }
}
