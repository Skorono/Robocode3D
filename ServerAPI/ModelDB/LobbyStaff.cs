namespace ServerAPI.ModelDB;

public class LobbyStaff
{
    public int LobbyId { get; set; }
    public int PlayerId { get; set; }

    public Player Player { get; set; } = default!;

    public Lobby Lobby { get; set; } = default!;
}