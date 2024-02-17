using Footsal.Entites.Teams;

namespace Footsal.Services.Teams.Contracts.Dtos;

public class UpdateTeamDto
{
    public string Name{ get; set; }
    public DressColor? MainColor { get; set; }
    public DressColor? MinorColor{ get; set; }
}