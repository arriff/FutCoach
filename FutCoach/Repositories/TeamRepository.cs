using FutCoach.Models;
using FutData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutCoach.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        private readonly FutcoachContext context;

        public TeamRepository(FutcoachContext context)
        {
            this.context = context;
        }

        public List<TeamViewModel> GetTeams()
        {
            return context.Teams.Select(n => new TeamViewModel
            {
                Id = n.TeamId,
                Name = n.TeamName,
                League = n.TeamLeague,
                Nation = n.TeamNation,
                League_id = n.LeagueId
            }).ToList();
        }
    }
}
