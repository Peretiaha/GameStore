
namespace GameStore.DAL.Repository
{
    using System;
    using System.Collections;
    using GameStore.DAL.Interfaces;
    using GameStoreModel;
    using GameStoreModel.Models;

    public class CommentRepository : Repository<Comment>, ICommentRepository
    {
        public CommentRepository(GameStoreDb gameStoreDb)
            : base(gameStoreDb)
        {
        }

        public IEnumerable GetCommentsByGameKey(string key)
        {
            throw new NotImplementedException();
        }

    }
}
