using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.BLL.Services
{
    using System.Linq;

    using GameStore.BLL.Interfaces;
    using GameStore.DAL.Interfaces;

    using GameStoreModel;
    using GameStoreModel.Models;

    using Microsoft.EntityFrameworkCore;

    public class CommentService : ICommentService
    {

        private readonly IUnitOfWork unitOfWork;

        private readonly IRepositoryFactory repositoryFactory;
        
        public void Create(Comment comment)
        {
            this.repositoryFactory.GetRepository<Comment>().Insert(comment);
            this.unitOfWork.Commit();
        }

        public void Delete(Comment comment)
        {
            this.repositoryFactory.GetRepository<Comment>().Delete(comment);
            this.unitOfWork.Commit();
        }

        public void Edit(Comment comment)
        {
            this.repositoryFactory.GetRepository<Comment>().Edit(comment);
            this.unitOfWork.Commit();
        }

        public IEnumerable<Comment> GetCommentsByGameKey(string key)
        {
            var game = this.repositoryFactory.GetRepository<Game>().GetSingle(x=>x.Key == key);
            var comments = this.repositoryFactory.GetRepository<Comment>().GetMany(x => x.GameId == game.GameId, null);
            return comments.ToList();
        }

        public void AddCommentToGame(Comment comment)
        {
            throw new NotImplementedException();
        }
    }
}
