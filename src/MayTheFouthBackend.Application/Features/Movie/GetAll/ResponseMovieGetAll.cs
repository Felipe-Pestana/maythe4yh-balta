using MayTheFouthBackend.Application.Dtos;
using MayTheFouthBackend.Application.Features.Shared;

namespace MayTheFouthBackend.Application.Features.Movie.GetAll
{
    public sealed class ResponseMovieGetAll : Response
    {
        public ResponseMovieGetAll()
        {
            
        }
        public ResponseMovieGetAll(string message, int status)
        {
            Message = message;
            StatusCode = status;
        }
        public ResponseMovieGetAll(string message, PaginatedListResponse<MovieDto>? data)
        {
            Message = message;
            Data = data;
            StatusCode = 200; 
        }

        public PaginatedListResponse<MovieDto>? Data { get; set; }
    }
}
