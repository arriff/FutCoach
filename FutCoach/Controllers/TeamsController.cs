using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FutCoach.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FutCoach.Controllers
{
    public class TeamsController : Controller
    {
        private readonly ITeamRepository repo;

        public TeamsController(ITeamRepository repo)
        {
            this.repo = repo;
        }

        public IActionResult Show()
        {
            var list = repo.GetTeams();
            return View(@"~/Views/Team/Allteams.cshtml", list);
        }
    }
}