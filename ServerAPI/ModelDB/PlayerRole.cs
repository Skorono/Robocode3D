using System.ComponentModel.DataAnnotations;

namespace ServerAPI.ModelDB;

public class PlayerRole
{
    [Key]
    public char Id { get; set; }
    
    public string Name { get; set; } = default!;
}