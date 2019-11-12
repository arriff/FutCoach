using FutCoach.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutCoach.Controllers
{
    public class LeaguesController : Controller
    {
        private readonly ILeagueRepository repo;

        public LeaguesController(ILeagueRepository repo)
        {
            this.repo = repo;
        }
        public IActionResult Show()
        {
            var list = repo.GetLeagues();
            return View(@"~/Views/League/Allleagues.cshtml", list);
        }
    }
}
