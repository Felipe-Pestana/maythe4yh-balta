﻿using MayTheFouthBackend.Application.Mappers;
using MayTheFouthBackend.Domain.Interfaces.IRepositories;
using MediatR;

namespace MayTheFouthBackend.Application.Features.Character.GetAll;

public class CharacterGetAllQueryHandler : IRequestHandler<CharacterGetAllQuery, ResponseCharacterGetAll>
{
    private readonly IUnitOfWork _uow;

    public CharacterGetAllQueryHandler(IUnitOfWork uow)
            => _uow = uow;

    public async Task<ResponseCharacterGetAll> Handle(CharacterGetAllQuery request, CancellationToken cancellationToken)
    {
        try
        {
            var resultEntity = await _uow.CharacterRepository.GetAllCharactWhithInfosAsync();

            if (!resultEntity.Any())
                return new ResponseCharacterGetAll("Não existe qual quer Personagem Registado!", 400);

            var resultDto = resultEntity.MapToIEnumerableCharacterDto();

            return new ResponseCharacterGetAll("Listagem de Personagem existentes", resultDto.ToPaginationList(request.CurrentPage, request.PageSize));

        }
        catch (Exception ex)
        {
            return new ResponseCharacterGetAll(ex.Message, 500);
        }
    }
}

