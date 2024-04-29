using MayTheFouthBackend.Application.Mappers;
using MayTheFouthBackend.Domain.Interfaces.IRepositories;
using MediatR;

namespace MayTheFouthBackend.Application.Features.Movie.GetAll;

public sealed class MovieGetAllQueryHandler : IRequestHandler<MovieGetAllQuery, ResponseMovieGetAll>
{
    private readonly IUnitOfWork _unitOfWork;

    public MovieGetAllQueryHandler(IUnitOfWork unitOfWork)
        => _unitOfWork = unitOfWork;
    

    public async Task<ResponseMovieGetAll> Handle(MovieGetAllQuery request, CancellationToken cancellationToken)
    {
        try
        {
            var resultEntity = await _unitOfWork.MoviesRepository.GetAllAsync();

            if (!resultEntity.Any())
                return new ResponseMovieGetAll("Não existe qual quer Filme Registado!", 400);

            var resultDto = resultEntity.MapToIEnumerableMoviesDto();

            return new ResponseMovieGetAll("Listagem de Filmes existentes", resultDto.ToPaginationList(request.CurrentPage, request.PageSize));


        }
        catch (Exception ex)
        {
            return new ResponseMovieGetAll(ex.Message, 500); 
        }
    }
}
