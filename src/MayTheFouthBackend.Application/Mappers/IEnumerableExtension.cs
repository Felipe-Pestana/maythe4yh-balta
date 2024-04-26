using MayTheFouthBackend.Application.Features.Shared;

namespace MayTheFouthBackend.Application.Mappers; 

public static class IEnumerableExtension
{
    private const int defaultCurrentPage = 1;
    private const int defaulPageSize = 10;

    public static PaginatedListResponse<T> ToPaginationList<T>(this IEnumerable<T> source, int currentPage, int pageSize) where T : class
    {
        currentPage = currentPage > 0 ? currentPage : defaultCurrentPage;
        pageSize = pageSize > 0 ? pageSize : defaulPageSize;
        var totalItems = source.Count();
        var items = source.Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();

        return new PaginatedListResponse<T>(items, totalItems, currentPage, pageSize);
    }
}
