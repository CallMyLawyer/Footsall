namespace Footsal.Services.Players.Contracts.Dtos;

public class GetPlayerDto
{
    public int Id{ get; set; }
    public string FirstName{ get; set; }
    public string LastName{ get; set; }
    public TimeSpan BirthDate{ get; set; } 
}