namespace ServerAPI.ModelDB;

public class Player
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;

    public string Login { get; set; } = default!;

    public string Password { get; set; } = default!;
}