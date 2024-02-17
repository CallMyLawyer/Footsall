using Footsal.Entites.Teams;
using Footsal.Services.Teams.Contracts.Dtos;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Footsal.Services.Teams.Contracts;

public interface ITeamRepository
{
   void Add(Team team);
   bool DressColor(int mainColor, int minorColor);
   bool RepeatName(string teamName );
   List<GetTeamDto> Get(string? name, DressColor? mainColor , DressColor? minorColor);
   Team Update(int id , UpdateTeamDto dto);
   EntityEntry<Team> Delete(int id);

}