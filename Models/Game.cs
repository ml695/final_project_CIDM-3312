using System.ComponentModel.DataAnnotations;

namespace final_project_CIDM_3312.Models;

public class Game
{
    public int GameID {get; set;} // PK
    public string GameName {get; set;} = string.Empty;
    public string Protagonist {get; set;} = string.Empty;
    public string GameDesc {get; set;} = string.Empty;
    public string ImageURL {get; set;} = string.Empty;
    public List<GameGenre>? GameGenres = default!; // NP
}

public class GameGenre
{
    public int GameID {get; set;} // CPK, FK1
    public int GenreID {get; set;} // CPK, FK2
    public Game Game {get; set;} = default!; // NP
    public Genre Genre {get; set;} = default!; // NP
}