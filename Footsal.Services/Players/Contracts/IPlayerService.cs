using Footsal.Entites.Playesr;

namespace Footsal.Services.Players.Contracts.Dtos;

public interface IPlayerService
{
    Task Add(AddPlayerDto dto);
    List<GetPlayerDto> Get(int id);
    Task Delete(int id);
}