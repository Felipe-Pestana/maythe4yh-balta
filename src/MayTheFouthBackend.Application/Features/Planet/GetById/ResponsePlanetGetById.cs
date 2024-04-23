using MayTheFouthBackend.Application.Dtos;
using MayTheFouthBackend.Application.Features.Shared;

namespace MayTheFouthBackend.Application.Features.Planet.GetById
{
    public class ResponsePlanetGetById : Response
    {
        public ResponsePlanetGetById()
        {

        }
        public ResponsePlanetGetById(string message, int status)
        {
            Message = message;
            StatusCode = status;
        }
        public ResponsePlanetGetById(string message, PlanetDto data)
        {
            Message = message;
            Data = data;
            StatusCode = 200;
        }

        public PlanetDto? Data { get; set; }
    }
}
