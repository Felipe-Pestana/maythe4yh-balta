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
<<<<<<< HEAD
        public ResponseStarshipGetAll(string message, PaginatedListResponse<StarshipDto> datas)
=======
        public ResponseStarshipGetAll(string message, PaginatedListResponse<StarshipDto>? datas)
>>>>>>> 9f6c629a500cbed5a36a9be86cec98165d2566b3
        {
            Message = message;
            Datas = datas;
            StatusCode = 200;
        }

        public PaginatedListResponse<StarshipDto>? Datas { get; set; }
    }
}
