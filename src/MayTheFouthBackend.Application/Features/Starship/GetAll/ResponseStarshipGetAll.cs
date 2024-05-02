using MayTheFouthBackend.Application.Dtos;
using MayTheFouthBackend.Application.Features.Shared;

namespace MayTheFouthBackend.Application.Features.Starship.GetAll
{
    public class ResponseStarshipGetAll : Response
    {
        public ResponseStarshipGetAll() { }

        public ResponseStarshipGetAll(string message, int status)
        {
            Message = message;
            StatusCode = status;
        }
        public ResponseStarshipGetAll(string message, PaginatedListResponse<StarshipDto>? data)
        {
            Message = message;
            Data = data;
            StatusCode = 200;
        }

        public PaginatedListResponse<StarshipDto>? Data { get; set; }
    }
}
