using Microsoft.EntityFrameworkCore;
using ServerAPI.ModelDB;

namespace ServerAPI.DbContext;

public class PostgresContext: Microsoft.EntityFrameworkCore.DbContext
{
    public virtual DbSet<Player> Players { get; set; }
    public virtual DbSet<Lobby> Lobbies { get; set; }
    public virtual DbSet<LobbyStaff> LobbyStaves { get; set; }
    public virtual DbSet<LobbyVisibility> LobbyVisibilities { get; set; }

    public PostgresContext() : base()
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=;Database=Robocode3DServerService;Username=postgres;Password=");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<LobbyStaff>().HasKey(ls =>
        new {
            ls.LobbyId, ls.PlayerId
        });
    }
}