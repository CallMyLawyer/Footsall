using System.ComponentModel.DataAnnotations;

namespace Footsal.Entites.Teams;

public class Team
{
    [Key]
    public int Id{ get; set; }
    public string Name{ get; set; }
    public DressColor MainColor { get; set; }
    public DressColor MinorColor{ get; set; }
    public int PlayerCount{ get; set; }
}

public enum DressColor
{
    White= 1,
     Red= 2,
     Blue =3,
     Yellow=4
}