namespace MayTheFouthBackend.Application.Features.Shared; 

public class PaginatedListResponse<T> where T : class
{
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
    public int Count { get; set; }
    public int TotalPage { get; set; }
    public int TotalItems { get; set; }
    public IEnumerable<T> DataItem { get; set; } = Enumerable.Empty<T>();

    public PaginatedListResponse(IEnumerable<T> items, int totalItems, int currentPage, int pageSize)
    {
        PageNumber = currentPage;
        PageSize = pageSize;
        Count = totalItems;
        TotalItems = totalItems;
        TotalPage = (int)Math.Ceiling(totalItems /(double) pageSize);
        DataItem = items; 
    }
}
