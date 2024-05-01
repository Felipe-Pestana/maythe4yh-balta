using MayTheFouthBackend.Application.Features.Planet.GetById;
using MayTheFouthBackend.Application.Mappers;
using MayTheFouthBackend.Domain.Interfaces.IRepositories;
using MediatR;

namespace MayTheFouthBackend.Application.Features.Character.GetById;

public class CharacterGetByIdQueryHandler : IRequestHandler<CharacterGetByIdQuery, ResponseCharacterGetById>
{
    private readonly IUnitOfWork _uow;

    public CharacterGetByIdQueryHandler(IUnitOfWork uow)
            => _uow = uow;
    public async Task<ResponseCharacterGetById> Handle(CharacterGetByIdQuery request, CancellationToken cancellationToken)
    {
        try
        {
            var result = await _uow.CharacterRepository.GetCharacterByIdWithInfoAsync(request.Id);

            if (result == null)
                return new ResponseCharacterGetById("Personagem não encontrado", 404);

            var person = result.MapToCharacterDto();

            return new ResponseCharacterGetById("Personagem localizado com sucesso!", person);
        }
        catch (Exception ex)
        {
            return new ResponseCharacterGetById(ex.Message, 500);
        }
    }
}
