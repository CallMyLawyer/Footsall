using Footsal.Entites.Teams;
using Footsal.Services.Teams.Contracts;
using Footsal.Services.Teams.Contracts.Dtos;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Footsal.Persistence.Teams;

public class EFRepositoryTeam : ITeamRepository
{
    private readonly EFDataContext _context;

    public EFRepositoryTeam(EFDataContext context)
    {
        _context = context;
    }
    public void Add(Team team)
    {
        _context.Teams.Add(team);
    }

    public bool DressColor(int mainColor, int minorColor)
    {
        if (minorColor==mainColor)
        {
            
        }

        return true;
    }

    public bool RepeatName(string teamName )
    {
        if (_context.Teams.Any(_=>_.Name==teamName))
        {
            return true;
        }

        return false;
    }

    public List<GetTeamDto> Get(string? name, DressColor? mainColor,
        DressColor? minorColor)
    {
        var teams = _context.Teams.Select(_ => new GetTeamDto()
        {
            Id = _.Id,
            Name = _.Name,
            MainColor = _.MainColor,
            MinorColor = _.MinorColor
        }).ToList();
        if (name!=null)
        {
            var team =teams.Where(_ => _.Name == name).ToList();
            return team;
        }

        if (mainColor!=null && minorColor!=null )
        {
            var team = teams.Where(_ => _.MinorColor == minorColor && _.MainColor == mainColor).ToList();
            return team;
        }

        return teams;
    }

    public Team Update(int id , UpdateTeamDto? dto)
    {
        var updateTeam = _context.Teams.First(_=>_.Id == id);
        return updateTeam;
    }

    public EntityEntry<Team> Delete(int id)
    {
        var deleteTeam = _context.Teams.First(_ => _.Id == id);
        return _context.Remove(deleteTeam);
    }
}