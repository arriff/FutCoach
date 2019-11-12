using FutCoach.Models;
using FutData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutCoach.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly FutcoachContext context;

        public PlayerRepository(FutcoachContext context)
        {
            this.context = context;
        }

        public List<PlayerViewModel> GetPlayers()
        {
            return context.Players.Select(n => new PlayerViewModel
            {
                Id = n.PlayerId,
                Firstname = n.PlayerFirstname,
                Lastname = n.PlayerLastname,
                Nation = n.PlayerNation,
                Team = n.PlayerTeam,
                League = n.PlyaerLeague,
                Position = n.PlayerPosition,
                Pace = n.PlayerPace,
                Shooting = n.PlayerShooting,
                Passing = n.PlayerPassing,
                Dribbling = n.PlayerDribbling,
                Defending = n.PlayerDefending,
                Physicality = n.PlayerPhysicality,
                Team_id = n.TeamId
            }).ToList();
        }

        public PlayerViewModel GetPlayerById(int playerID)
        {
            var playerList = GetPlayers();
            var playerModel = playerList.Single(p => p.Id == playerID);
            return playerModel;
        }

        public void AddPlayer(PlayerViewModel playerModel)
        {
            context.Players.Add(new Players
            {
                PlayerId = playerModel.Id,
                PlayerFirstname = playerModel.Firstname,
                PlayerLastname = playerModel.Lastname,
                PlayerNation = playerModel.Nation,
                PlayerTeam = playerModel.Team,
                PlyaerLeague = playerModel.League,
                PlayerPosition = playerModel.Position,
                PlayerPace = playerModel.Pace,
                PlayerShooting = playerModel.Shooting,
                PlayerPassing = playerModel.Passing,
                PlayerDribbling = playerModel.Dribbling,
                PlayerDefending = playerModel.Defending,
                PlayerPhysicality = playerModel.Physicality,
                TeamId = playerModel.Team_id
            });
            context.SaveChanges();
        }
    }
}
