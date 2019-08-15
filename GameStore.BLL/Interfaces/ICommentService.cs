using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.BLL.Interfaces
{
    using GameStoreModel.Interfaces;
    using GameStoreModel.Models;

    public interface ICommentService : IServices<Comment>
    {
        void Create(Comment comment);

        void Edit(Comment comment);

        void Delete(Comment comment);

        IEnumerable<Comment> GetCommentsByGameKey(string key);

        void AddCommentToGame(Comment comment);
    }
}
