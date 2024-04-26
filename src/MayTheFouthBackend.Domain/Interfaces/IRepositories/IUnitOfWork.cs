﻿namespace MayTheFouthBackend.Domain.Interfaces.IRepositories;

public interface IUnitOfWork
{
    public IPlanetRepository PlanetRepository { get;}

    public IStarshipRepository StarshipRepository { get;}

    public ICharacterRepository CharacterRepository { get; }
  
    Task Commit(CancellationToken cancellationToken);
}
