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
            new Game { GameID = 1, GameName = "Fable (2004)", Protagonist = "Hero of Oakvale", GameDesc = "Each person you aid, each flower you crush, and each creature you slay will change this world forever. Fable: Who will you be?"},

            new Game { GameID = 2, GameName = "Detroit: Become Human", Protagonist = "Connor-Kara-Markus", GameDesc = "Shape the fate of androids and humanity through your choices in a near-future world divided by fear, freedom, and revolution."},

            new Game { GameID = 3, GameName = "The Elder Scrolls IV: Oblivion", Protagonist = "Hero of Kvatch", GameDesc = "Close the gates of Oblivion and save Tamriel from the Daedric invasion in this expansive fantasy RPG."},

            new Game { GameID = 4, GameName = "The Elder Scrolls V: Skyrim", Protagonist = "Dragonborn", GameDesc = "Master the power of dragons and forge your destiny across the frozen lands of Skyrim."},

            new Game { GameID = 5, GameName = "Fallout 3", Protagonist = "Lone Wanderer", GameDesc = "Venture into the Capital Wasteland and uncover the secrets left behind after nuclear devastation."},

            new Game { GameID = 6, GameName = "Fallout: New Vegas", Protagonist = "Courier", GameDesc = "Survive betrayal and shape the future of New Vegas in a brutal struggle for power in the Mojave Wasteland."},

            new Game { GameID = 7, GameName = "RuneScape", Protagonist = "Adventurer", GameDesc = "Explore the vast world of Gielinor, complete quests, master skills, and forge your own legendary journey."},

            new Game { GameID = 8, GameName = "Mass Effect", Protagonist = "Commander Shepard", GameDesc = "Lead an elite crew across the galaxy to stop an ancient threat and save all sentient life."},

            new Game { GameID = 9, GameName = "Cyberpunk 2077", Protagonist = "V", GameDesc = "Fight for survival and immortality in the dangerous neon-lit streets of Night City."},

            new Game { GameID = 10, GameName = "Call of Duty: Modern Warfare 2 (2009)", Protagonist = "Task Force 141-Rangers", GameDesc = "Battle across the globe in a high-stakes war against ultranationalist forces and global terrorism."},

            new Game { GameID = 11, GameName = "Call of Duty: World at War", Protagonist = "Marines-Red Army", GameDesc = "Experience the brutal final battles of World War II across the Pacific and Eastern Fronts."},

            new Game { GameID = 12, GameName = "Call of Duty: Black Ops 2", Protagonist = "David Mason-Alex Mason", GameDesc = "Confront a global cyberwar and a ruthless enemy in a branching story shaped by your decisions."},

            new Game { GameID = 13, GameName = "Battlefield 1", Protagonist = "Allied Forces", GameDesc = "Fight through gripping war stories inspired by the battles and heroes of World War I."},

            new Game { GameID = 14, GameName = "Star Wars Battlefront II (2005)", Protagonist = "Republic-Empire-Rebels", GameDesc = "Relive iconic Star Wars battles across the galaxy from the perspectives of legendary armies."},

            new Game { GameID = 15, GameName = "Ready or Not", Protagonist = "SWAT", GameDesc = "Lead elite tactical officers through intense hostage rescues, raids, and high-risk operations."},

            new Game { GameID = 16, GameName = "Left 4 Dead 2", Protagonist = "Coach-Ellis-Nick-Rochelle", GameDesc = "Survive relentless zombie hordes with teamwork, quick thinking, and desperate firepower."},

            new Game { GameID = 17, GameName = "Resident Evil: Requiem", Protagonist = "Grace-Leon", GameDesc = "Uncover terrifying conspiracies and survive horrifying bio-organic threats in the next chapter of survival horror."},

            new Game { GameID = 18, GameName = "Resident Evil 7: Biohazard", Protagonist = "Ethan Winters", GameDesc = "Search for your missing wife inside a decaying plantation filled with unimaginable horrors."},

            new Game { GameID = 19, GameName = "Dead Space", Protagonist = "Isaac Clarke", GameDesc = "Fight to survive aboard a derelict mining ship overrun by grotesque alien monstrosities."},

            new Game { GameID = 20, GameName = "Dead Space 2", Protagonist = "Isaac Clarke", GameDesc = "Battle terrifying hallucinations and necromorph outbreaks in a desperate fight for survival."},

            new Game { GameID = 21, GameName = "Stellaris", Protagonist = "Empire", GameDesc = "Guide a spacefaring civilization through diplomacy, war, exploration, and galactic conquest."},

            new Game { GameID = 22, GameName = "Sid Meier's Civilization V", Protagonist = "Civilization", GameDesc = "Build an empire to stand the test of time through strategy, diplomacy, science, and war."},

            new Game { GameID = 23, GameName = "PowerWash Simulator", Protagonist = "Power Washer", GameDesc = "Wash away dirt and grime while restoring vehicles, homes, and entire locations to spotless perfection."},

            new Game { GameID = 24, GameName = "Microsoft Flight Simulator", Protagonist = "Pilot", GameDesc = "Take to the skies and explore a stunningly realistic recreation of the entire world."},

            new Game { GameID = 25, GameName = "Golf With Your Friends", Protagonist = "Golfers", GameDesc = "Compete with friends across chaotic mini-golf courses packed with obstacles and surprises."},

            new Game { GameID = 26, GameName = "Super Battle Golf", Protagonist = "Golfers", GameDesc = "Battle opponents in fast-paced golf matches where precision and chaos collide."},

            new Game { GameID = 27, GameName = "Garry's Mod", Protagonist = "Player", GameDesc = "Create, experiment, and unleash endless sandbox chaos using physics and community-made content."},

            new Game { GameID = 28, GameName = "The Sims 4", Protagonist = "Sims", GameDesc = "Create and control virtual lives while building homes, relationships, and unique stories."},

            new Game { GameID = 29, GameName = "Minecraft", Protagonist = "Steve-Alex", GameDesc = "Mine, craft, and survive in a limitless block-based world shaped entirely by your imagination."},

            new Game { GameID = 30, GameName = "Mario Party 6", Protagonist = "Mario-Friends", GameDesc = "Compete in outrageous mini-games and board game challenges with friends in the Mushroom Kingdom."},

            new Game { GameID = 31, GameName = "Mario Kart", Protagonist = "Mario-Friends", GameDesc = "Race through colorful tracks using speed boosts, power-ups, and chaotic competition."},

            new Game { GameID = 32, GameName = "Super Smash Bros. Melee", Protagonist = "Nintendo Fighters", GameDesc = "Battle iconic Nintendo characters in fast-paced platform fighting arenas."},

            new Game { GameID = 33, GameName = "Super Smash Bros. Ultimate", Protagonist = "Nintendo Fighters", GameDesc = "Fight with the largest roster of gaming icons in an all-out crossover battle."},

            new Game { GameID = 34, GameName = "Mortal Kombat: Deadly Alliance", Protagonist = "Raiden-Kung Lao", GameDesc = "Defend Earthrealm against the deadly alliance of Shang Tsung and Quan Chi in brutal martial combat."},

            new Game { GameID = 35, GameName = "Halo: The Master Chief Collection", Protagonist = "Master Chief", GameDesc = "Experience the legendary Halo saga across multiple campaigns and multiplayer experiences as humanity’s greatest Spartan hero."},

            new Game { GameID = 36, GameName = "Grand Theft Auto V", Protagonist = "Michael-Trevor-Franklin", GameDesc = "Carry out daring heists and survive the chaos of Los Santos in a sprawling open-world crime epic."},

            new Game { GameID = 37, GameName = "Wolfenstein: The New Order", Protagonist = "B.J. Blazkowicz", GameDesc = "Lead the resistance against a technologically advanced Nazi regime in an intense alternate-history shooter."},

            new Game { GameID = 38, GameName = "Wolfenstein II: The New Colossus", Protagonist = "B.J. Blazkowicz", GameDesc = "Fight to liberate America from Nazi occupation in a brutal and story-driven first-person shooter adventure."},

            new Game { GameID = 39, GameName = "Splinter Cell: Double Agent", Protagonist = "Sam Fisher", GameDesc = "Go undercover as a double agent to infiltrate a terrorist organization while balancing loyalty, deception, and survival in high-stakes stealth operations."},

            new Game { GameID = 40, GameName = "Payday 2", Protagonist = "PAYDAY Crew", GameDesc = "Team up to execute high-stakes heists, plan elaborate robberies, and escape with the loot in this cooperative first-person shooter."}
        );

        context.SaveChanges();

        if (context.Genres.Any()) 
        {
            return;
        }

        List<Genre> genres = new List<Genre>
        {
            new Genre{ GenreID = 1, GenreName = "Action", GenreDesc = "Fast-paced gameplay focused on combat, reflexes, and real-time challenges.", ImageURL = "img/action.jpg" },
            new Genre{ GenreID = 2, GenreName = "Adventure", GenreDesc = "Story-driven gameplay emphasizing exploration, puzzles, and narrative progression.", ImageURL = "img/adventure.jpg" },
            new Genre{ GenreID = 3, GenreName = "Role-Playing", GenreDesc = "Character progression, quests, and stat-based gameplay in immersive worlds.", ImageURL = "img/role-playing.jpg" },
            new Genre{ GenreID = 4, GenreName = "First-Person Shooter", GenreDesc = "Combat-focused games played from the protagonist's first-person perspective.", ImageURL = "img/first-person shooter.jpg" },
            new Genre{ GenreID = 5, GenreName = "Third-Person Shooter", GenreDesc = "Shooter games featuring an over-the-shoulder or external player viewpoint.", ImageURL = "img/third-person shooter.jpg" },
            new Genre{ GenreID = 6, GenreName = "Strategy", GenreDesc = "Games requiring tactical planning, resource management, and decision-making.", ImageURL = "img/strategy.jpg" },
            new Genre{ GenreID = 7, GenreName = "Real-Time Strategy", GenreDesc = "Strategy games where actions occur continuously without turn-based pauses.", ImageURL = "img/real-time strategy.jpg" },
            new Genre{ GenreID = 8, GenreName = "Turn-Based Strategy", GenreDesc = "Strategic gameplay where players take actions in alternating turns.", ImageURL = "img/turn-based strategy.jpg" },
            new Genre{ GenreID = 9, GenreName = "Simulation", GenreDesc = "Games designed to realistically imitate activities, systems, or environments.", ImageURL = "img/simulator.jpg" },
            new Genre{ GenreID = 10, GenreName = "Sports", GenreDesc = "Games based on real or fictional sports competitions and athletic activities.", ImageURL = "img/sports.jpg" },
            new Genre{ GenreID = 11, GenreName = "Racing", GenreDesc = "Vehicle-focused games centered on speed, driving skill, and competition.", ImageURL = "img/racing.jpg" },
            new Genre{ GenreID = 12, GenreName = "Puzzle", GenreDesc = "Games that challenge logic, pattern recognition, and problem-solving abilities.", ImageURL = "img/puzzle.webp" },
            new Genre{ GenreID = 13, GenreName = "Platformer", GenreDesc = "Games involving jumping between platforms and navigating obstacle-filled levels.", ImageURL = "img/platformer.jpg" },
            new Genre{ GenreID = 14, GenreName = "Survival", GenreDesc = "Gameplay focused on resource gathering, crafting, and staying alive in hostile conditions.", ImageURL = "img/survival.jpg" },
            new Genre{ GenreID = 15, GenreName = "Horror", GenreDesc = "Games intended to create fear, tension, and suspenseful experiences.", ImageURL = "img/horror.webp" },
            new Genre{ GenreID = 16, GenreName = "Stealth", GenreDesc = "Gameplay emphasizing avoiding detection and silently overcoming obstacles or enemies.", ImageURL = "img/stealth.jpg" },
            new Genre{ GenreID = 17, GenreName = "Open World", GenreDesc = "Games featuring large, freely explorable environments with non-linear objectives.", ImageURL = "img/open world.png" },
            new Genre{ GenreID = 18, GenreName = "Sandbox", GenreDesc = "Games allowing creative freedom and experimentation with minimal restrictions.", ImageURL = "img/sandbox.webp" },
            new Genre{ GenreID = 19, GenreName = "Multiplayer Online Battle Arena", GenreDesc = "Team-based competitive games focused on strategic battles between player-controlled heroes.", ImageURL = "img/mmo.jpg" },
            new Genre{ GenreID = 20, GenreName = "Battle Royale", GenreDesc = "Large-scale survival competition where players fight until only one remains.", ImageURL = "img/battle royale.jpg" },
            new Genre{ GenreID = 21, GenreName = "Massively Multiplayer Online", GenreDesc = "Online games supporting large numbers of players in persistent virtual worlds.", ImageURL = "img/mmo.jpg" },
            new Genre{ GenreID = 22, GenreName = "Card Game", GenreDesc = "Games based on collectible, strategic, or deck-building card mechanics.", ImageURL = "img/card game.avif" },
            new Genre{ GenreID = 23, GenreName = "Party Games", GenreDesc = "Multiplayer-focused games designed for social gatherings, featuring mini-games, competitions, or cooperative fun.", ImageURL = "img/party game.avif" },
            new Genre{ GenreID = 24, GenreName = "Fighting", GenreDesc = "Combat-focused games where players battle opponents using martial arts, weapons, or special abilities in competitive matches.", ImageURL = "img/fighting.png" },
            new Genre{ GenreID = 25, GenreName = "Roguelike", GenreDesc = "Games featuring procedural generation, permadeath, and highly replayable mechanics.", ImageURL = "img/roguelike.jpg" }
        };

        context.AddRange(genres);
        context.SaveChanges();

        List<GameGenre> gameGenres = new List<GameGenre>
        {
            new GameGenre{ GameID = 1, GenreID = 1 }, // Fable - Action
            new GameGenre{ GameID = 1, GenreID = 2 }, // Fable - Adventure
            new GameGenre{ GameID = 1, GenreID = 3 }, // Fable - Role-Playing
            new GameGenre{ GameID = 1, GenreID = 17 }, // Fable - Open World

            new GameGenre{ GameID = 2, GenreID = 2 }, // Detroit: Become Human - Adventure
            new GameGenre{ GameID = 2, GenreID = 3 }, // Detroit: Become Human - Role-Playing

            new GameGenre{ GameID = 3, GenreID = 2 }, // Oblivion - Adventure
            new GameGenre{ GameID = 3, GenreID = 3 }, // Oblivion - Role-Playing
            new GameGenre{ GameID = 3, GenreID = 17 }, // Oblivion - Open World

            new GameGenre{ GameID = 4, GenreID = 1 }, // Skyrim - Action
            new GameGenre{ GameID = 4, GenreID = 2 }, // Skyrim - Adventure
            new GameGenre{ GameID = 4, GenreID = 3 }, // Skyrim - Role-Playing
            new GameGenre{ GameID = 4, GenreID = 17 }, // Skyrim - Open World

            new GameGenre{ GameID = 5, GenreID = 1 }, // Fallout 3 - Action
            new GameGenre{ GameID = 5, GenreID = 3 }, // Fallout 3 - Role-Playing
            new GameGenre{ GameID = 5, GenreID = 4 }, // Fallout 3 - FPS
            new GameGenre{ GameID = 5, GenreID = 17 }, // Fallout 3 - Open World

            new GameGenre{ GameID = 6, GenreID = 1 }, // Fallout: New Vegas - Action
            new GameGenre{ GameID = 6, GenreID = 3 }, // Fallout: New Vegas - RPG
            new GameGenre{ GameID = 6, GenreID = 4 }, // Fallout: New Vegas - FPS
            new GameGenre{ GameID = 6, GenreID = 17 }, // Fallout: New Vegas - Open World

            new GameGenre{ GameID = 7, GenreID = 3 }, // RuneScape - RPG
            new GameGenre{ GameID = 7, GenreID = 17 }, // RuneScape - Open World
            new GameGenre{ GameID = 7, GenreID = 21 }, // RuneScape - MMO

            new GameGenre{ GameID = 8, GenreID = 1 }, // Mass Effect - Action
            new GameGenre{ GameID = 8, GenreID = 3 }, // Mass Effect - RPG
            new GameGenre{ GameID = 8, GenreID = 5 }, // Mass Effect - TPS

            new GameGenre{ GameID = 9, GenreID = 1 }, // Cyberpunk 2077 - Action
            new GameGenre{ GameID = 9, GenreID = 3 }, // Cyberpunk 2077 - RPG
            new GameGenre{ GameID = 9, GenreID = 4 }, // Cyberpunk 2077 - FPS
            new GameGenre{ GameID = 9, GenreID = 17 }, // Cyberpunk 2077 - Open World

            new GameGenre{ GameID = 10, GenreID = 1 }, // MW2 - Action
            new GameGenre{ GameID = 10, GenreID = 4 }, // MW2 - FPS

            new GameGenre{ GameID = 11, GenreID = 1 }, // World at War - Action
            new GameGenre{ GameID = 11, GenreID = 4 }, // World at War - FPS

            new GameGenre{ GameID = 12, GenreID = 1 }, // Black Ops 2 - Action
            new GameGenre{ GameID = 12, GenreID = 4 }, // Black Ops 2 - FPS

            new GameGenre{ GameID = 13, GenreID = 1 }, // Battlefield 1 - Action
            new GameGenre{ GameID = 13, GenreID = 4 }, // Battlefield 1 - FPS

            new GameGenre{ GameID = 14, GenreID = 1 }, // Battlefront II - Action
            new GameGenre{ GameID = 14, GenreID = 4 }, // Battlefront II - FPS
            new GameGenre{ GameID = 14, GenreID = 5 }, // Battlefront II - TPS

            new GameGenre{ GameID = 15, GenreID = 1 }, // Ready or Not - Action
            new GameGenre{ GameID = 15, GenreID = 4 }, // Ready or Not - FPS
            new GameGenre{ GameID = 15, GenreID = 16 }, // Ready or Not - Stealth

            new GameGenre{ GameID = 16, GenreID = 1 }, // Left 4 Dead 2 - Action
            new GameGenre{ GameID = 16, GenreID = 4 }, // Left 4 Dead 2 - FPS
            new GameGenre{ GameID = 16, GenreID = 14 }, // Left 4 Dead 2 - Survival
            new GameGenre{ GameID = 16, GenreID = 15 }, // Left 4 Dead 2 - Horror

            new GameGenre{ GameID = 17, GenreID = 1 }, // Resident Evil: Requiem - Action
            new GameGenre{ GameID = 17, GenreID = 14 }, // Resident Evil: Requiem - Survival
            new GameGenre{ GameID = 17, GenreID = 15 }, // Resident Evil: Requiem - Horror
            new GameGenre{ GameID = 17, GenreID = 12 }, // Resident Evil: Requiem - Puzzle

            new GameGenre{ GameID = 18, GenreID = 14 }, // Resident Evil 7 - Survival
            new GameGenre{ GameID = 18, GenreID = 15 }, // Resident Evil 7 - Horror
            new GameGenre{ GameID = 18, GenreID = 12 }, // Resident Evil 7 - Puzzle

            new GameGenre{ GameID = 19, GenreID = 1 }, // Dead Space - Action
            new GameGenre{ GameID = 19, GenreID = 14 }, // Dead Space - Survival
            new GameGenre{ GameID = 19, GenreID = 15 }, // Dead Space - Horror
            new GameGenre{ GameID = 19, GenreID = 12 }, // Dead Space - Puzzle

            new GameGenre{ GameID = 20, GenreID = 1 }, // Dead Space 2 - Action
            new GameGenre{ GameID = 20, GenreID = 14 }, // Dead Space 2 - Survival
            new GameGenre{ GameID = 20, GenreID = 15 }, // Dead Space 2 - Horror
            new GameGenre{ GameID = 20, GenreID = 12 }, // Dead Space 2 - Puzzle

            new GameGenre{ GameID = 21, GenreID = 6 }, // Stellaris - Strategy
            new GameGenre{ GameID = 21, GenreID = 7 }, // Stellaris - RTS

            new GameGenre{ GameID = 22, GenreID = 6 }, // Civ V - Strategy
            new GameGenre{ GameID = 22, GenreID = 8 }, // Civ V - Turn-Based Strategy

            new GameGenre{ GameID = 23, GenreID = 9 }, // PowerWash Simulator - Simulation

            new GameGenre{ GameID = 24, GenreID = 9 }, // Microsoft Flight Simulator - Simulation

            new GameGenre{ GameID = 25, GenreID = 10 }, // Golf With Your Friends - Sports
            new GameGenre{ GameID = 25, GenreID = 23 }, // Golf With Your Friends - Party Games

            new GameGenre{ GameID = 26, GenreID = 10 }, // Super Battle Golf - Sports
            new GameGenre{ GameID = 26, GenreID = 23 }, // Super Battle Golf - Party Games

            new GameGenre{ GameID = 27, GenreID = 18 }, // Garry's Mod - Sandbox
            new GameGenre{ GameID = 27, GenreID = 9 }, // Garry's Mod - Simulation

            new GameGenre{ GameID = 28, GenreID = 9 }, // The Sims 4 - Simulation

            new GameGenre{ GameID = 29, GenreID = 14 }, // Minecraft - Survival
            new GameGenre{ GameID = 29, GenreID = 17 }, // Minecraft - Open World
            new GameGenre{ GameID = 29, GenreID = 18 }, // Minecraft - Sandbox

            new GameGenre{ GameID = 30, GenreID = 23 }, // Mario Party 6 - Party Games

            new GameGenre{ GameID = 31, GenreID = 10 }, // Mario Kart - Sports
            new GameGenre{ GameID = 31, GenreID = 11 }, // Mario Kart - Racing
            new GameGenre{ GameID = 31, GenreID = 23 }, // Mario Kart - Party Games

            new GameGenre{ GameID = 32, GenreID = 1 }, // Smash Bros Melee - Action
            new GameGenre{ GameID = 32, GenreID = 24 }, // Smash Bros Melee - Fighting
            new GameGenre{ GameID = 32, GenreID = 23 }, // Smash Bros Melee - Party Games

            new GameGenre{ GameID = 33, GenreID = 1 }, // Smash Bros Ultimate - Action
            new GameGenre{ GameID = 33, GenreID = 24 }, // Smash Bros Ultimate - Fighting
            new GameGenre{ GameID = 33, GenreID = 23 }, // Smash Bros Ultimate - Party Games

            new GameGenre{ GameID = 34, GenreID = 1 }, // Mortal Kombat: Deadly Alliance - Action
            new GameGenre{ GameID = 34, GenreID = 24 }, // Mortal Kombat: Deadly Alliance - Fighting

            new GameGenre{ GameID = 35, GenreID = 1 }, // Halo: The Master Chief Collection - Action
            new GameGenre{ GameID = 35, GenreID = 4 }, // Halo: The Master Chief Collection - FPS
            new GameGenre{ GameID = 35, GenreID = 5 }, // Halo: The Master Chief Collection - TPS
            new GameGenre{ GameID = 35, GenreID = 14 }, // Halo: The Master Chief Collection - Survival

            new GameGenre{ GameID = 36, GenreID = 1 }, // Grand Theft Auto V - Action
            new GameGenre{ GameID = 36, GenreID = 2 }, // Grand Theft Auto V - Adventure
            new GameGenre{ GameID = 36, GenreID = 5 }, // Grand Theft Auto V - TPS
            new GameGenre{ GameID = 36, GenreID = 17 }, // Grand Theft Auto V - Open World
            new GameGenre{ GameID = 36, GenreID = 18 }, // Grand Theft Auto V - Sandbox

            new GameGenre{ GameID = 37, GenreID = 1 }, // Wolfenstein: The New Order - Action
            new GameGenre{ GameID = 37, GenreID = 4 }, // Wolfenstein: The New Order - FPS
            new GameGenre{ GameID = 37, GenreID = 2 }, // Wolfenstein: The New Order - Adventure

            new GameGenre{ GameID = 38, GenreID = 1 }, // Wolfenstein II: The New Colossus - Action
            new GameGenre{ GameID = 38, GenreID = 4 }, // Wolfenstein II: The New Colossus - FPS
            new GameGenre{ GameID = 38, GenreID = 2 }, // Wolfenstein II: The New Colossus - Adventure

            new GameGenre{ GameID = 39, GenreID = 1 }, // Splinter Cell: Double Agent - Action
            new GameGenre{ GameID = 39, GenreID = 4 }, // Splinter Cell: Double Agent - FPS (hybrid stealth shooter perspective)
            new GameGenre{ GameID = 39, GenreID = 16 }, // Splinter Cell: Double Agent - Stealth
            new GameGenre{ GameID = 39, GenreID = 2 }, // Splinter Cell: Double Agent - Adventure

            new GameGenre{ GameID = 40, GenreID = 1 }, // Payday 2 - Action
            new GameGenre{ GameID = 40, GenreID = 4 }, // Payday 2 - FPS
            new GameGenre{ GameID = 40, GenreID = 16 } // Payday 2 - Stealth

        };

        context.AddRange(gameGenres);
        context.SaveChanges();
    }
}