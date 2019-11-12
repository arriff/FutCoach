using FutCoach.Models;
using FutData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutCoach.Repositories
{
    public class LeagueRepository : ILeagueRepository
    {
        private readonly FutcoachContext context;

        public LeagueRepository(FutcoachContext context)
        {
            this.context = context;
        }

        public List<LeagueViewModel> GetLeagues()
        {
            return context.Leagues.Select(n => new LeagueViewModel
            {
               Id = n.LeagueId,
               Name = n.LeagueName,
               Nation = n.LeagueNation,
               Nation_id = n.NationId
            }).ToList();
        }
    }
}
