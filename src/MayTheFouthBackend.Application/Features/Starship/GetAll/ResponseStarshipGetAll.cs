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
        public ResponseStarshipGetAll(string message, PaginatedListResponse<StarshipDto>? datas)
        {
            Message = message;
            Datas = datas;
            StatusCode = 200;
        }

        public PaginatedListResponse<StarshipDto>? Datas { get; set; }
    }
}
