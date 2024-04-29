using MayTheFouthBackend.Application.Mappers;
using MayTheFouthBackend.Domain.Interfaces.IRepositories;
using MediatR;

namespace MayTheFouthBackend.Application.Features.Movie.GetById;

public sealed class MovieGetByIdQueryHandler : IRequestHandler<MovieGetByIdQuery, ResponseMovieGetById>
{
    private readonly IUnitOfWork _unitOfWork;

    public MovieGetByIdQueryHandler(IUnitOfWork unitOfWork)
        => _unitOfWork = unitOfWork;


    public async Task<ResponseMovieGetById> Handle(MovieGetByIdQuery request, CancellationToken cancellationToken)
    {
        try
        {
            var result = await _unitOfWork.MoviesRepository.GetMoviesByIdWithInfoAsync(request.Id);

            if (result is null)
                return new ResponseMovieGetById("não foi encontrado filme com esse Id", 400);

            var resultDto = result.MapMovieToDto();
            return new ResponseMovieGetById("Filme encontrado com sucesso!", resultDto);

        }
        catch (Exception ex)
        {
            return new ResponseMovieGetById(ex.Message, 500);
        }

    }
}
