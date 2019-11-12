using FutCoach.Models;
using System.Collections.Generic;

namespace FutCoach.Repositories
{
    public interface ITeamRepository
    {
        List<TeamViewModel> GetTeams();
    }
}