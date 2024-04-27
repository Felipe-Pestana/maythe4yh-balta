namespace MayTheFouthBackend.Application.Dtos
{
    public class PlanetDto
    {
        public string Name { get; set; } = string.Empty;
        public float RotationPeriod { get; set; }
        public int OrbitalPeriod { get; set; }
        public int Diameter { get; set; }
        public string Climate { get; set; } = string.Empty;
        public string Gravity { get; set; } = string.Empty;
        public string Terrain { get; set; } = string.Empty;
        public float SurfaceWater { get; set; }
        public int Population { get; set; }
        public IEnumerable<ListInfoDto> Characters { get; set; } = Enumerable.Empty<ListInfoDto>();
        public IEnumerable<ListInfoDto> Movies { get; set; } = Enumerable.Empty<ListInfoDto>();

    }
}
