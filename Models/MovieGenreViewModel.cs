using Microsoft.AspNetCore.Mvc.Rendering;
using MvcMovie.Controllers;

namespace MvcMovie.Models;

public class MovieGenreViewModel
{
    public List<Movie>? Movies { get; set; }
    public SelectList? Genres { get; set; }
    public SelectList? Sorts { get; set; }
    public string? MovieGenre { get; set; }
    public string? SearchString { get; set; }
    public MoviesController.Sort Sort { get; set; }
}