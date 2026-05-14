using System.ComponentModel.DataAnnotations;

namespace final_project_CIDM_3312.Models;

public class Genre
{
    public int GenreID {get; set;} // PK
    [Display(Name = "Tag Description")]
    public string GenreDesc {get; set;} = string.Empty;
    [Display(Name = "Tag Name")]
    public string GenreName {get; set;} = string.Empty;
    public string ImageURL {get; set;} = string.Empty;
    public List<GameGenre>? GameGenres {get; set;} = default!; // NP
}