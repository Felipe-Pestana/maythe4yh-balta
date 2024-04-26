using MediatR;

namespace MayTheFouthBackend.Application.Features.Character.GetById;

public class CharacterGetByIdQuery : IRequest<ResponseCharacterGetById>
{
    public int Id { get; set; }

}
