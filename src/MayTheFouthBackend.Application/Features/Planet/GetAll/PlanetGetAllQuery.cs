using MediatR;

namespace MayTheFouthBackend.Application.Features.Planet.GetAll; 

public sealed class PlanetGetAllQuery : IRequest<ResponsePlanetGetAll>
{
    public int CurrentPage { get; set; }
    public int PageSize { get; set; }
}
