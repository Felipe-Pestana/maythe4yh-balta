using MayTheFouthBackend.Application.Dtos;
using MayTheFouthBackend.Application.Features.Shared;

namespace MayTheFouthBackend.Application.Features.Movie.GetById; 

public sealed class ResponseMovieGetById : Response
{
    public ResponseMovieGetById()
    {
        
    }
    public ResponseMovieGetById(string message, int status)
    {
        Message = message; 
        StatusCode = status;
    }
    public ResponseMovieGetById( string message, MovieDto? data)
    {
        Message = message; 
        Data = data;
        StatusCode = 200; 
    }
    public MovieDto? Data { get; set; }
}
