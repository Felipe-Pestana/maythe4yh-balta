using MayTheFouthBackend.Application.Features.Planet.GetAll;
using MediatR;

namespace MayTheFouthBackend.Application.Features.Character.GetAll;

public sealed class CharacterGetAllQuery : IRequest<ResponseCharacterGetAll>
{
    public int CurrentPage { get; set; }
    public int PageSize { get; set; }
}
