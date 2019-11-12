
using FutCoach.Models;
using System.Collections.Generic;

namespace FutCoach.Repositories
{
    public interface IPlayerRepository
    {
        List<PlayerViewModel> GetPlayers();
        PlayerViewModel GetPlayerById(int playerID);
        void AddPlayer(PlayerViewModel playerModel);
    }
}