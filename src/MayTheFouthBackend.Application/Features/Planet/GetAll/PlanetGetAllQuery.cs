using MediatR;

namespace MayTheFouthBackend.Application.Features.Planet.GetAll; 

public sealed class PlanetGetAllQuery : IRequest<ResponsePlanetGetAll>
{
    public int CurrentPage { get; set; }
    public int PageSize { get; set; }

    public static bool TryParse(string value, out PlanetGetAllQuery result)
    {
        result = null;

        var parameters = value.Split('&')
                              .Select(p => p.Split('='))
                              .ToDictionary(p => p[0], p => p.Length > 1 ? p[1] : null);

        if (parameters.ContainsKey("currentPage") && parameters.ContainsKey("pageSize") &&
            int.TryParse(parameters["currentPage"], out int currentPage) && int.TryParse(parameters["pageSize"], out int pageSize))
        {
            result = new PlanetGetAllQuery { CurrentPage = currentPage, PageSize = pageSize };
            return true;
        }

        return false;
    }
}
