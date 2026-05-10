using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;

namespace final_project_CIDM_3312.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new AppDbContext(serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>());

        if (context.Games.Any()) 
        {
            return;
        }

        context.Games.AddRange(
            new Game { GameID = 1, GameName = "Fable"}
        );

        context.SaveChanges();

        if (context.Genres.Any()) 
        {
            return;
        }

        context.Genres.AddRange(
            new Genre{ GenreID = 1, GenreName = "Action", GenreDesc = "Fast-paced gameplay focused on combat, reflexes, and real-time challenges." },
            new Genre{ GenreID = 2, GenreName = "Adventure", GenreDesc = "Story-driven gameplay emphasizing exploration, puzzles, and narrative progression." },
            new Genre{ GenreID = 3, GenreName = "Role-Playing", GenreDesc = "Character progression, quests, and stat-based gameplay in immersive worlds." },
            new Genre{ GenreID = 4, GenreName = "First-Person Shooter", GenreDesc = "Combat-focused games played from the protagonist's first-person perspective." },
            new Genre{ GenreID = 5, GenreName = "Third-Person Shooter", GenreDesc = "Shooter games featuring an over-the-shoulder or external player viewpoint." },
            new Genre{ GenreID = 6, GenreName = "Strategy", GenreDesc = "Games requiring tactical planning, resource management, and decision-making." },
            new Genre{ GenreID = 7, GenreName = "Real-Time Strategy", GenreDesc = "Strategy games where actions occur continuously without turn-based pauses." },
            new Genre{ GenreID = 8, GenreName = "Turn-Based Strategy", GenreDesc = "Strategic gameplay where players take actions in alternating turns." },
            new Genre{ GenreID = 9, GenreName = "Simulation", GenreDesc = "Games designed to realistically imitate activities, systems, or environments." },
            new Genre{ GenreID = 10, GenreName = "Sports", GenreDesc = "Games based on real or fictional sports competitions and athletic activities." },
            new Genre{ GenreID = 11, GenreName = "Racing", GenreDesc = "Vehicle-focused games centered on speed, driving skill, and competition." },
            new Genre{ GenreID = 12, GenreName = "Puzzle", GenreDesc = "Games that challenge logic, pattern recognition, and problem-solving abilities." },
            new Genre{ GenreID = 13, GenreName = "Platformer", GenreDesc = "Games involving jumping between platforms and navigating obstacle-filled levels." },
            new Genre{ GenreID = 14, GenreName = "Survival", GenreDesc = "Gameplay focused on resource gathering, crafting, and staying alive in hostile conditions." },
            new Genre{ GenreID = 15, GenreName = "Horror", GenreDesc = "Games intended to create fear, tension, and suspenseful experiences." },
            new Genre{ GenreID = 16, GenreName = "Stealth", GenreDesc = "Gameplay emphasizing avoiding detection and silently overcoming obstacles or enemies." },
            new Genre{ GenreID = 17, GenreName = "Open World", GenreDesc = "Games featuring large, freely explorable environments with non-linear objectives." },
            new Genre{ GenreID = 18, GenreName = "Sandbox", GenreDesc = "Games allowing creative freedom and experimentation with minimal restrictions." },
            new Genre{ GenreID = 19, GenreName = "Multiplayer Online Battle Arena", GenreDesc = "Team-based competitive games focused on strategic battles between player-controlled heroes." },
            new Genre{ GenreID = 20, GenreName = "Battle Royale", GenreDesc = "Large-scale survival competition where players fight until only one remains." },
            new Genre{ GenreID = 21, GenreName = "Massively Multiplayer Online", GenreDesc = "Online games supporting large numbers of players in persistent virtual worlds." },
            new Genre{ GenreID = 22, GenreName = "Card Game", GenreDesc = "Games based on collectible, strategic, or deck-building card mechanics." },
            new Genre{ GenreID = 23, GenreName = "Rhythm", GenreDesc = "Music-based gameplay requiring players to match beats, timing, or sequences." },
            new Genre{ GenreID = 24, GenreName = "Visual Novel", GenreDesc = "Narrative-focused games combining text storytelling with visual artwork and choices." },
            new Genre{ GenreID = 25, GenreName = "Roguelike", GenreDesc = "Games featuring procedural generation, permadeath, and highly replayable mechanics." }
        );

        context.SaveChanges();
    }
}