using MediatR;

namespace MayTheFouthBackend.Application.Features.Planet.GetById;

public class PlanetGetByIdQuery : IRequest<ResponsePlanetGetById>
{
    public int Id { get; set; }
}
