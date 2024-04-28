using MayTheFouthBackend.Application.Dtos;
using MayTheFouthBackend.Application.Mappers;
using MayTheFouthBackend.Domain.Interfaces.IRepositories;
using MediatR;

namespace MayTheFouthBackend.Application.Features.Starship.GetAll
{
    public class StarshipGetAllQueryHandler : IRequestHandler<StarshipGetAllQuery, ResponseStarshipGetAll>
    {
        private readonly IUnitOfWork _uow;

        public StarshipGetAllQueryHandler(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<ResponseStarshipGetAll> Handle(StarshipGetAllQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _uow.StarshipRepository.GetAllAsync();

                if (!result.Any())
                {
                    return new ResponseStarshipGetAll("Não existe nenhuma nave registrada", 400);
                }

                var resultDto = result.MapToIEnumerableStarhipDto();
                return new ResponseStarshipGetAll("Listagem de Naves", resultDto.ToPaginationList(request.CurrentPage, request.PageSize));

            }
            catch (Exception ex)
            {
                return new ResponseStarshipGetAll("Erro no servidor.", 500);
            }
        }
    }

}
