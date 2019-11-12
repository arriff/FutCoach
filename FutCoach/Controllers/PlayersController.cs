using FutCoach.Models;
using FutCoach.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutCoach.Controllers
{
    public class PlayersController : Controller
    {
        private readonly IPlayerRepository repo;

        public PlayersController(IPlayerRepository repo)
        {
            this.repo = repo;
        }
        public IActionResult Show()
        {
            var list = repo.GetPlayers();
            return View(@"~/Views/Player/Allplayers.cshtml", list);
        }
        public ActionResult Add()
        {
            return View(@"~/Views/Player/Add.cshtml", new PlayerViewModel());
        }

        [HttpPost]
        public ActionResult Add(PlayerViewModel playerModel)
        {
            
            repo.AddPlayer(playerModel);
            return RedirectToAction("Show");
        }
    }
}
