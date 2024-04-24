using MayTheFouthBackend.Application.Dtos;
using MayTheFouthBackend.Application.Features.Shared;

namespace MayTheFouthBackend.Application.Features.Character.GetAll;

public class ResponseCharacterGetAll: Response
{
    public ResponseCharacterGetAll()
    {

    }
    public ResponseCharacterGetAll(string message, int status)
    {
        Message = message;
        StatusCode = status;
    }
    public ResponseCharacterGetAll(string message, PaginatedListResponse<CharacterDto> datas)
    {
        Message = message;
        Datas = datas;
        StatusCode = 200;

    }

    public PaginatedListResponse<CharacterDto>? Datas { get; set; }
}
