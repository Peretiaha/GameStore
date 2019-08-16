using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.BLL.Interfaces
{
    using GameStoreModel.Interfaces;
    using GameStoreModel.Models;

    public interface ICommentService : IServices<Comment>
    {
       new void Create(Comment comment);

        new void Edit(Comment comment);

        new void Delete(Comment comment);

        IEnumerable<Comment> GetCommentsByGameKey(string key);

        void AddCommentToGame(Comment comment);
    }
}
