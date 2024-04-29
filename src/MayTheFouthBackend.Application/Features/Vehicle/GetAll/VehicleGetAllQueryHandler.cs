using MayTheFouthBackend.Application.Mappers;
using MayTheFouthBackend.Application.Mappins;
using MayTheFouthBackend.Domain.Interfaces.IRepositories;
using MediatR;

namespace MayTheFouthBackend.Application.Features.Starship.GetAll
{
    public class VehicleGetAllQueryHandler : IRequestHandler<VehicleGetAllQuery, ResponseVehicleGetAll>
    {
        private readonly IUnitOfWork _uow;

        public VehicleGetAllQueryHandler(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<ResponseVehicleGetAll> Handle(VehicleGetAllQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _uow.VehicleRepository.GetAllAsync();

                if (!result.Any())
                {
                    return new ResponseVehicleGetAll("Não existe nenhum veículo registrada", 400);
                }

                var resultDto = result.MapToIEnumerableVehicleDto();

                return new ResponseVehicleGetAll("Listagem de veículos existente", resultDto.ToPaginationList(request.CurrentPage, request.PageSize));
            }
            catch (Exception ex)
            {
                return new ResponseVehicleGetAll("Erro no servidor.", 500);
            }
        }
    }

}
