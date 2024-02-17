using Footsal.Entites.Playesr;
using Footsal.Services.Players.Contracts;
using Footsal.Services.Players.Contracts.Dtos;
using Footsal.TaavContracts;

namespace Footsal.Services.Players;

public class PlayerAppService : IPlayerService
{
    private readonly IPlayerRepository _repository;
    private readonly IUnitOfWork _unitOfWork;

    public PlayerAppService(IPlayerRepository repository ,
        IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task Add(AddPlayerDto dto)
    {
        var player = new Player()
        {
         FirstName = dto.FirstName,
         LastName = dto.LastName,
         BirthDate = dto.BirthDate
        };
        _repository.Add(player);
         await _unitOfWork.Complete();
    }

    public List<GetPlayerDto> Get(int id)
    {
       return _repository.Get(id);
    }

    public async Task Delete(int id)
    {
        var player = _repository.Delete(id);
        _repository.Delete(id);
       await _unitOfWork.Complete();
    }
}