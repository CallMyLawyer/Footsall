using Footsal.Entites.Teams;
using Footsal.Services.Teams.Contracts.Dtos;

namespace Footsal.Services.Teams.Contracts;

public interface ITeamService
{
  Task Add(AddTeamDto dto);
  List<GetTeamDto>Get(string name , DressColor mainColor,
    DressColor minorColor);

  void Update(int id , UpdateTeamDto dto);
  void Delete(int id);
}