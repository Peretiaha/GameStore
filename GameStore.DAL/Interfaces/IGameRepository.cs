
using System.Collections.Generic;
using GameStoreModel.Models;

namespace GameStore.DAL.Interfaces
{

    public interface IGameRepository : IRepository<Game>
    {
        
        new void Create(Game game);

        new void Edit(Game game);

        new void Delete(Game game);
        
        Game GetGameByKey(string key);

        void AddCommentToGame(Comment comment);

        IEnumerable<Game> GetGemesByGenre(Genre genre);

        IEnumerable<Game> GetGameByPlatformType(PlatformType platformType);
    }
}
