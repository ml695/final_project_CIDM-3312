using Microsoft.EntityFrameworkCore;

namespace final_project_CIDM_3312.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<GameGenre>().HasKey(g => new {g.GameID, g.GenreID});
    }

    public DbSet<Game> Games {get; set;}
    public DbSet<Genre> Genres {get; set;}
    public DbSet<GameGenre> GameGenres {get; set;}
}