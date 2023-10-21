namespace ServerAPI.ModelDB;

public class Lobby
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int LobbyVisibilityId { get; set; }

    public LobbyVisibility LobbyStatus { get; set; }
}