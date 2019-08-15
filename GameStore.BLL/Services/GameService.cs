using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.BLL.Services
{
    using System.Linq;
    using System.Security.Cryptography.X509Certificates;

    using GameStore.BLL.Interfaces;
    using GameStore.DAL.Interfaces;

    using GameStoreModel;
    using GameStoreModel.Models;

    public class GameService : IGameService
    {
        private readonly IUnitOfWork unitOfWork;

        private readonly IRepositoryFactory repositoryFactory;

        public void Create(Game game)
        {
            this.repositoryFactory.GetRepository<Game>().Insert(game);
            this.unitOfWork.Commit();
        }

        public void Delete(Game game)
        {
            this.repositoryFactory.GetRepository<Game>().Delete(game);
            this.unitOfWork.Commit();

        }

        public void Edit(Game game)
        {
            this.repositoryFactory.GetRepository<Game>().Edit(game);
            this.unitOfWork.Commit();

        }

        public IEnumerable<Game> GetAllGames()
        {
            var games = this.repositoryFactory.GetRepository<Game>().GetMany(null,null);
            return games;
        }
        
        public Game GetGameByKey(string key)
        {
            var game = this.repositoryFactory.GetRepository<Game>().GetSingle(x =>x.Key == key);
            return game;
        }

        public IEnumerable<Game> GetGamesByGenre(Genre genre)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Game> GetGamesByPlatformType(PlatformType platformType)
        {
            throw new NotImplementedException();
        }
    }
}
