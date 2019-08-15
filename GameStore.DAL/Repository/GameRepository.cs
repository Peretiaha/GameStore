
using System;
using System.Collections.Generic;
using GameStore.DAL.Interfaces;
using GameStoreModel;
using GameStoreModel.Models;

namespace GameStore.DAL.Repository
{
    
    public class GameRepository : Repository<Game>, IGameRepository
    {
        public GameRepository(GameStoreDb gameStoreDb)
            : base(gameStoreDb)
        {
        }

        public new void Create(Game game)
        {
            throw new NotImplementedException();
        }

        public new void Edit(Game game)
        {
            throw new NotImplementedException();
        }

        public new void Delete(Game game)
        {
            throw new NotImplementedException();
        }

        public void AddCommentToGame(Comment comment)
        {
            throw new NotImplementedException();
        }

        public Game GetGameByKey(string key)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Game> GetGemesByGenre(Genre genre)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Game> GetGameByPlatformType(PlatformType platformType)
        {
            throw new NotImplementedException();
        }
    }
}
