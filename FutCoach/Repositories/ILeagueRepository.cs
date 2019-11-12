using System.Collections.Generic;
using FutCoach.Models;

namespace FutCoach.Repositories
{
    public interface ILeagueRepository
    {
        List<LeagueViewModel> GetLeagues();
    }
}