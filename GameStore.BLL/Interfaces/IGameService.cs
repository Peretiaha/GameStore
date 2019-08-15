using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.BLL.Interfaces
{
    using GameStoreModel.Interfaces;
    using GameStoreModel.Models;

    public interface IGameService : IServices<Game>
    {
        
        Game GetGameByKey(string key);

        IEnumerable<Game> GetAllGames();

        IEnumerable<Game> GetGamesByGenre(Genre genre);

        IEnumerable<Game> GetGamesByPlatformType(PlatformType platformType);



    }
}
