using Footsal.Entites.Teams;

namespace Footsal.Services.Teams.Contracts.Dtos;

public class GetTeamDto
{
    public int Id{ get; set; }
    public string Name{ get; set; }
    public DressColor? MainColor { get; set; }
    public DressColor? MinorColor{ get; set; }
}