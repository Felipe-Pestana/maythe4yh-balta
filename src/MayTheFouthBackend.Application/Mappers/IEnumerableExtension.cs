using MayTheFouthBackend.Application.Features.Shared;

namespace MayTheFouthBackend.Application.Mappers; 

public static class IEnumerableExtension
{
    public static PaginatedListResponse<T> ToPaginationList<T>(this IEnumerable<T> source, int currentPage, int pageSize) where T : class
    {
        var totalItems = source.Count();
        var items = source.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();

        return new PaginatedListResponse<T>(items, totalItems, currentPage, pageSize);
    }
}
