using System.ComponentModel.DataAnnotations.Schema;

namespace ServerAPI.ModelDB;

public class Player
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public string Login { get; set; } = default!;
    public string Password { get; set; } = default!;

    [ForeignKey("RoleId")]
    public int RoleId { get; set; }
    
    public PlayerRole PlayerRole { get; set; } = default!;
}