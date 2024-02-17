using Footsal.Entites.Playesr;
using Footsal.Services.Players.Contracts.Dtos;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Footsal.Services.Players.Contracts;

public interface IPlayerRepository
{
 void Add(Player player);
 List<GetPlayerDto> Get(int? id);
 EntityEntry<Player> Delete(int id);
}