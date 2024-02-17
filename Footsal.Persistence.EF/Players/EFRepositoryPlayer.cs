using Footsal.Entites.Playesr;
using Footsal.Entites.Teams;
using Footsal.Services.Players.Contracts;
using Footsal.Services.Players.Contracts.Dtos;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Footsal.Persistence.Players;

public class EFRepositoryPlayer : IPlayerRepository
{
    private readonly EFDataContext _context;

    public EFRepositoryPlayer(EFDataContext context)
    {
        _context = context;
    }
    public void Add(Player player)
    { 
        _context.Players.Add(player);
    }
    public List<GetPlayerDto> Get(int? id)
    {
        var players = _context.Players.Select(_ => new GetPlayerDto()
        {
            Id = _.Id,
            FirstName= _.FirstName,
            LastName = _.LastName,
            BirthDate = (DateTime.Today - _.BirthDate)/365 
        }).ToList();
        if (id!=null)
        {
            var player =players.Where(_ => _.Id == id).ToList();
            return player;
        }


        return players;
        
    }

    public EntityEntry<Player> Delete(int id)
    {
        var player = _context.Players.First(_=>_.Id==id);
        return _context.Remove(player);
    }
}