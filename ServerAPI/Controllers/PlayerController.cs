using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ServerAPI.DbContext;
using ServerAPI.ModelDB;

namespace ServerAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PlayerController: ControllerBase
{
    private readonly PostgresContext _context;

    public PlayerController(PostgresContext context)
    {
        _context = context;
        _context.Database.Migrate();
    }
    
    private Task<List<Player>> Players
    {
        get => _context.Players.ToListAsync();
    }

    /// <summary>
    /// Returns list of Players
    /// </summary>
    /// <returns>Player</returns>
    [HttpGet(Name = "GetPlayers")]
    public IEnumerable<List<Player>> GetPlayers()
    {
        yield return Players.Result;
    }
    
    [HttpGet("{id}", Name = "GetPlayerById")]
    public IEnumerable<Player> GetPlayerById(int id)
    {
        yield return Players.Result.First(p => p.Id == id);
    }

    [HttpPost("{id}, {name}, {login}, {password}", Name = "PostNewPlayer")]
    public async void MakePlayer(int id, string name, string login, string password)
    {
        await Task.Factory.StartNew(() => _context.Players.Add(new Player() { Id = id, Name = name, Password = password, Login = login }))
            .ContinueWith(_ => _context.SaveChangesAsync());
    }
}