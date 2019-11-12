using FutCoach.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutCoach.Controllers
{
    public class NationsController : Controller
    {
        private readonly INationRepository repo;

        public NationsController(INationRepository repo)
        {
            this.repo = repo;
        }
        public IActionResult Show()
        {
            var list = repo.GetNations();
            return View(@"~/Views/Nation/Allnations.cshtml", list);
        }
    }
}
