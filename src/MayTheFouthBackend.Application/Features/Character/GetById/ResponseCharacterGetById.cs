using MayTheFouthBackend.Application.Dtos;
using MayTheFouthBackend.Application.Features.Shared;

namespace MayTheFouthBackend.Application.Features.Character.GetById;

public class ResponseCharacterGetById : Response
{
    public ResponseCharacterGetById()
    {

    }
    public ResponseCharacterGetById(string message, int status)
    {
        Message = message;
        StatusCode = status;
    }
    public ResponseCharacterGetById(string message, CharacterDto data)
    {
        Message = message;
        Data = data;
        StatusCode = 200;
    }

    public CharacterDto? Data { get; set; }
}
