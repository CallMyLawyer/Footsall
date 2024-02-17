using Footsal.Services.Players.Contracts.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Footsal.RestApi.Controllers.Players;
[Route("player")]
public class PlayerController : Controller
{
 private readonly IPlayerService _playerService;

 public PlayerController(IPlayerService playerService)
 {
  _playerService = playerService;
 }

 [HttpPost]
 public async Task Add(AddPlayerDto dto)
 {
  await _playerService.Add(dto);
 }

 [HttpGet]
 public List<GetPlayerDto> Get(int id)
 {
   return _playerService.Get(id);
 }

 [HttpDelete]
 public Task Delete(int id)
 {
  return _playerService.Delete(id);
 }
}