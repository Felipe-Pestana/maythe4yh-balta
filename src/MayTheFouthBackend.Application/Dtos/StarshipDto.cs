namespace MayTheFouthBackend.Application.Dtos
{
    public class StarshipDto
    {
        public string Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string Manufacturer { get; set; } = string.Empty;
        public int CostInCredits { get; set; }
        public int Length { get; set; }
        public int Maxspeed { get; set; }
        public int Crew { get; set; }
        public int Passengers { get; set; }
        public int Cargocapacity { get; set; }
        public string HyperDriveRating { get; set; }
        public string MGLT { get; set; }
        public string Consumables { get; set; } = string.Empty;
        public string Class { get; set; } = string.Empty;
        public IEnumerable<ListInfoDto> Movies { get; set; } = Enumerable.Empty<ListInfoDto>();
    }
}
