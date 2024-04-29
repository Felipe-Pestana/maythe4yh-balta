using MediatR;

namespace MayTheFouthBackend.Application.Features.Movie.GetById; 

public class MovieGetByIdQuery : IRequest<ResponseMovieGetById>
{
    public int Id { get; set; }
}
