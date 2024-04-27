using MayTheFouthBackend.Application.Mappers;
using MayTheFouthBackend.Application.Mappins;
using MayTheFouthBackend.Domain.Interfaces.IRepositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayTheFouthBackend.Application.Features.Starship.GetById
{
    public class VehicleGetByIdQueryHandler : IRequestHandler<VehicleGetByIdQuery, ResponseVehicleGetById>
    {
        private readonly IUnitOfWork _uow;

        public VehicleGetByIdQueryHandler(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<ResponseVehicleGetById> Handle(VehicleGetByIdQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _uow.VehicleRepository.GetByIdAsync(request.Id);

                if (result == null)
                {
                    return new ResponseVehicleGetById("Veículo não existe", 404);
                }
                var vehicleDto = result.MapToVehicleDto();
                return new ResponseVehicleGetById("Veículo encontrado com sucesso.", vehicleDto);

            }
            catch(Exception ex)
            {
                return new ResponseVehicleGetById(ex.Message, 500);
            }
        }
    }
}
