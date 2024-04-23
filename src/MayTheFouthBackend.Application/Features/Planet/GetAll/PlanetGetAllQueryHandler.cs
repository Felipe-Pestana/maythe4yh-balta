using MayTheFouthBackend.Application.Mappers;
using MayTheFouthBackend.Application.Mappins;
using MayTheFouthBackend.Domain.Interfaces.IRepositories;
using MediatR;

namespace MayTheFouthBackend.Application.Features.Planet.GetAll;

public class PlanetGetAllQueryHandler : IRequestHandler<PlanetGetAllQuery, ResponsePlanetGetAll>
{
    private readonly IUnitOfWork _uow;

    public PlanetGetAllQueryHandler(IUnitOfWork uow)
            => _uow = uow;
    

    public async Task<ResponsePlanetGetAll> Handle(PlanetGetAllQuery request, CancellationToken cancellationToken)
    {
        try
        {
            var resultEntity = await _uow.PlanetRepository.GetAllAsync();

            if (!resultEntity.Any())
                return new ResponsePlanetGetAll("Não existe qual quer Planeta Registado!", 400);

            var resultDto = resultEntity.MapToIEnumerablePlanetDto(); 

            return new ResponsePlanetGetAll("Listagem de planetas existentes", resultDto.ToPaginationList(request.CurrentPage, request.PageSize));

        }catch (Exception ex)
        {
            return new ResponsePlanetGetAll("Erro interno do servidor", 500);
        }
    }
}
