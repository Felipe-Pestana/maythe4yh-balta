namespace MayTheFouthBackend.Domain.Entities.JoinEntity; 

public sealed class MovieVehicle
{
    public int MovieId { get; set; }
    public Movie Movie { get; set; }

    public int VehicleId { get; set; }
    public Vehicle Vehicle { get; set; }
}
