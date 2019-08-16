using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using GameStore.Models;


namespace GameStore.Controllers
{
    using GameStore.BLL.Interfaces;

    using GameStoreModel.Models;

    public class GameController : Controller
    {
        private readonly IGameService _gameService;

        public GameController(IGameService gameService)
        {
            this._gameService = gameService;
        }


        [Route("games/new")]
        [HttpPost]
        public IActionResult Create(Game game)
        {
            this._gameService.Create(game);
            return Json(game);
        }

        [Route("games/update")]
        [HttpPost]
        public IActionResult Edit(Game game)
        {
            this._gameService.Edit(game);
            return Json(game);
        }

        [Route("games/remove")]
        [HttpPost]
        public IActionResult Delete(Game game)
        {
            this._gameService.Delete(game);
            return Json(game);
        }


    }
}