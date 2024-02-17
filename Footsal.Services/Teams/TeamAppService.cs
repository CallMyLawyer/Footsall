using Footsal.Entites.Teams;
using Footsal.Services.Teams.Contracts;
using Footsal.Services.Teams.Contracts.Dtos;
using Footsal.TaavContracts;

namespace Footsal.Services.Teams;

public class TeamAppService : ITeamService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ITeamRepository _repository;

    public TeamAppService(IUnitOfWork unitOfWork 
        , ITeamRepository repository)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }
    public async Task Add(AddTeamDto dto)
    {
        var team = new Team()
        {
         Name = dto.Name,
         MainColor = dto.MainColor,
         MinorColor = dto.MinorColor
        };
        if (_repository.RepeatName(dto.Name))
        {
            throw new Exception("The Name Is Already Exist!");
        }
        if (_repository.DressColor( (int)dto.MainColor,(int)dto.MinorColor))
        {
            throw new Exception("The Color Of MainDress And MinorDress Can Not Be The Same!");
        }
        _repository.Add(team);
        await _unitOfWork.Complete();
    }

    public List<GetTeamDto> Get(string name , DressColor mainColor,
        DressColor minorColor)
    {
        return _repository.Get(name, mainColor, minorColor);
    }

    public void Update(int id , UpdateTeamDto dto)
    {
        var updateTeam = _repository.Update(id ,dto );
        updateTeam.Name = dto.Name;
        updateTeam.MainColor = (DressColor)dto.MainColor;
        updateTeam.MinorColor = (DressColor)dto.MinorColor;
        if (_repository.RepeatName(dto.Name))
        {
            throw new Exception("The Name Is Already Exist!");
        }
        if (_repository.DressColor((int)dto.MainColor,(int)dto.MinorColor))
        {
            throw new Exception("The Color Of MainDress And MinorDress Can Not Be The Same");
        }
        _unitOfWork.Complete();
    }

    public void Delete(int id)
    {
        var team = _repository.Delete(id); 
        _repository.Delete(id);
        _unitOfWork.Complete();
    }
}