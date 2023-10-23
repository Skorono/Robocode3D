using Microsoft.EntityFrameworkCore;
using ServerAPI.ModelDB;

namespace ServerAPI.DbContext;

public class PostgresContext: Microsoft.EntityFrameworkCore.DbContext
{
    public virtual DbSet<Player> Players { get; set; }
    public virtual DbSet<Lobby> Lobbies { get; set; }
    public virtual DbSet<LobbyStaff> LobbyStaves { get; set; }
    public virtual DbSet<LobbyVisibility> LobbyVisibilities { get; set; }

    public PostgresContext(DbContextOptions<PostgresContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<LobbyStaff>().HasKey(ls =>
        new {
            ls.LobbyId, ls.PlayerId
        });

        modelBuilder.Entity<Player>().HasData(new List<Player>()
        {
            new Player() { Id = 1, Name = "Listik", Login = "qwerty123", Password = "123"}
        });
    }
}