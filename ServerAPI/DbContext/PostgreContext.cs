using Microsoft.EntityFrameworkCore;
using ServerAPI.ModelDB;

namespace ServerAPI.DbContext;

public class PostgresContext: Microsoft.EntityFrameworkCore.DbContext
{
    public virtual DbSet<Player> Players { get; set; } = null!;
    public virtual DbSet<Lobby> Lobbies { get; set; } = null!;
    public virtual DbSet<LobbyStaff> LobbyStaves { get; set; } = null!;
    public virtual DbSet<LobbyVisibility> LobbyVisibilities { get; set; } = null!;
    public virtual DbSet<PlayerRole> PlayerRoles { get; set; } = null!;

    public PostgresContext(DbContextOptions<PostgresContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<LobbyStaff>().HasKey(ls =>
        new {
            ls.LobbyId, ls.PlayerId
        });

        modelBuilder.Entity<PlayerRole>().HasData( new List<PlayerRole>()
        {
            new PlayerRole() { Id = UserRoles.Admin, Name = nameof(UserRoles.Admin)  },
            new PlayerRole() { Id = UserRoles.Helper, Name = nameof(UserRoles.Helper) },
            new PlayerRole() { Id = UserRoles.Player, Name = nameof(UserRoles.Player) }
        });
    }
}