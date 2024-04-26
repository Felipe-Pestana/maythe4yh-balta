using MayTheFouthBackend.Application.Dtos;
using MayTheFouthBackend.Application.Features.Shared;

namespace MayTheFouthBackend.Application.Features.Planet.GetAll
{
    public class ResponsePlanetGetAll : Response
    {
        public ResponsePlanetGetAll()
        {

        }
        public ResponsePlanetGetAll(string message, int status)
        {
            Message = message;
            StatusCode = status;
        }
        public ResponsePlanetGetAll(string message, PaginatedListResponse<PlanetDto> datas)
        {
            Message = message;
            Datas = datas;
            StatusCode = 200;

        }

        public PaginatedListResponse<PlanetDto>? Datas { get; set; }
    }
}
