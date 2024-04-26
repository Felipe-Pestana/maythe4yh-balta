using MayTheFouthBackend.Application.Mappins;
using MayTheFouthBackend.Domain.Interfaces.IRepositories;
using MediatR;

namespace MayTheFouthBackend.Application.Features.Planet.GetById
{
    public class PlanetGetByIdQueryHandler : IRequestHandler<PlanetGetByIdQuery, ResponsePlanetGetById>
    {
        private readonly IUnitOfWork _uow;

        public PlanetGetByIdQueryHandler(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<ResponsePlanetGetById> Handle(PlanetGetByIdQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _uow.PlanetRepository.GetPlanetWithInfo(request.Id);

                if (result == null)
                    return new ResponsePlanetGetById("Planeta não encontrado", 404);

                var planetDto = result.MapToPlanetDto();

                return new ResponsePlanetGetById("planeta localizado com sucesso!", planetDto); 
            }
            catch (Exception ex)
            {
                return new ResponsePlanetGetById(ex.Message, 500);
            }
        }
    }
}
