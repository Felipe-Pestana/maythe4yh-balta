﻿using MayTheFouthBackend.Domain.Interfaces.IRepositories;
using MayTheFouthBackend.Infra.Data.Contexts;

namespace MayTheFouthBackend.Infra.Data.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private IPlanetRepository _planetRepository;
    private IStarshipRepository _starshipRepository;
    private ICharacterRepository _characterRepository;
    private IMovieRepository _movieRepository;
    private IVehicleRepository _vehicleRepository;

    private readonly ApplicationDbContext _context;

    public UnitOfWork(ApplicationDbContext context)
    {
        _context = context;
    }

    public IPlanetRepository PlanetRepository => _planetRepository ?? new PlanetRepository(_context);
    public IStarshipRepository StarshipRepository => _starshipRepository ?? new StarshipRepository(_context);
    public ICharacterRepository CharacterRepository => _characterRepository ?? new CharacterRepository(_context);
    public IMovieRepository MovieRepository => _movieRepository ?? new MovieRepository(_context);
    public IVehicleRepository VehicleRepository => _vehicleRepository ?? new VehicleRepository(_context);

    public async Task Commit(CancellationToken cancellationToken)
    {
        await _context.SaveChangesAsync();
    }
}
