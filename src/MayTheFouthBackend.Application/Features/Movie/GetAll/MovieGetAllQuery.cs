using MediatR;

namespace MayTheFouthBackend.Application.Features.Movie.GetAll
{
    public sealed class MovieGetAllQuery : IRequest<ResponseMovieGetAll>
    {
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
    }
}
