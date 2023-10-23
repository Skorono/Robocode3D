using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ServerAPI.DbContext;
using ServerAPI.ModelDB;

namespace ServerAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PlayerController: ControllerBase
{
    private PostgresContext _context;

    public PlayerController(PostgresContext context) => _context = context;
    
    private List<Player> Players
    {
        get => _context.Players.ToList();
    }

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