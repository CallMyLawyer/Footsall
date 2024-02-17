using Footsal.Entites.Teams;
using Footsal.Services.Teams.Contracts;
using Footsal.Services.Teams.Contracts.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Footsal.RestApi.Controllers.Teams;
[Route("Team")]
public class TeamController : Controller
{
    private readonly ITeamService _service;

    public TeamController(ITeamService service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task Add(AddTeamDto dto)
    {
        await _service.Add(dto);
    }

    [HttpGet]
    public List<GetTeamDto> Get(string name, DressColor mainColor,
        DressColor minorColor)
    {
        return _service.Get(name, mainColor, minorColor);
    }

    [HttpPatch]
    public void Update(int id, UpdateTeamDto updateTeamDto)
    {
         _service.Update(id, updateTeamDto);
    }

    [HttpDelete]
    public void Delete(int id)
    {
        _service.Delete(id);
    }
}