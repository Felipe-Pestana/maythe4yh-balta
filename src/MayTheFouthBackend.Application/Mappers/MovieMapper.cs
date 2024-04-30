using MayTheFouthBackend.Application.Dtos;
using MayTheFouthBackend.Domain.Entities;

namespace MayTheFouthBackend.Application.Mappers; 

public static class MovieMapper
{
    public static MovieDto MapMovieToDto(this Movie movie)
    {
        return new MovieDto
        {
            Title = movie.Title,
            Created = movie.Created,
            Director = movie.Director,
            Edited = movie.Edited,
            Episode = movie.Episode,
            Producer = movie.Producer,
            ReleaseDate = movie.ReleaseDate,
            OpeningCrawl = movie.OpeningCrawl,
            Planets = movie.Planets?.Select(p => new ListInfoDto { Id = p.Id, Title = p.Name }),
            Characters = movie.Characters?.Select(p => new ListInfoDto { Id = p.Id, Title = p.Name }),
            Starships = movie.Starships?.Select(p => new ListInfoDto { Id = p.Id, Title = p.Name }),
            Vehicles = movie.Vehicles?.Select(p => new ListInfoDto { Id = p.Id, Title = p.Name})

        }; 
    }
    public static IEnumerable<MovieDto> MapToIEnumerableMoviesDto(this IEnumerable<Movie> movies)
    {
        var MoviesDto = new List<MovieDto>();
        foreach (var movie in movies)
        {
            MoviesDto.Add(MapMovieToDto(movie));
        }
        return MoviesDto;
    }
}
