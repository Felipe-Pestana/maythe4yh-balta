using MayTheFouthBackend.Application.Mappers;
using MayTheFouthBackend.Domain.Interfaces.IRepositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayTheFouthBackend.Application.Features.Starship.GetById
{
    public class StarshipGetByIdQueryHandler : IRequestHandler<StarshipGetByIdQuery, ResponseStarshipGetById>
    {
        private readonly IUnitOfWork _uow;

        public StarshipGetByIdQueryHandler(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<ResponseStarshipGetById> Handle(StarshipGetByIdQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _uow.StarshipRepository.GetByIdAsync(request.Id);

                if (result == null)
                {
                    return new ResponseStarshipGetById("Nave não existe", 404);
                }
                var starshipDto = result.MapToStarshipDto();
                return new ResponseStarshipGetById("Nave encontrada com sucesso.", starshipDto);

            }
            catch(Exception ex)
            {
                return new ResponseStarshipGetById(ex.Message, 500);
            }
        }
    }
}
