using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ServerAPI.ModelDB;

namespace ServerAPI.Controllers;

[Route("api/[controller]")]
public class PlayerController: Controller
{
    private IEnumerable<Player> Players { get; set; } = new[] { new Player() { Id = 1, Name = "Listik" }};

    /// <summary>
    /// Returns list of Players
    /// </summary>
    /// <returns>Player</returns>
    [HttpGet(Name = "GetPlayers")]
    public IEnumerable<Player> GetPlayers()
    {
        return Players;
    }
    
    [HttpGet("{id}", Name = "GetPlayerById")]
    public IEnumerable<Player> GetPlayerById(int id)
    {
        return Players.Where(p => p.Id == id);
    }

    [HttpPost(Name = "PostNewPlayer")]
    public void MakePlayer()
    {
        
    }
}