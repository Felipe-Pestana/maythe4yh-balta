﻿namespace MayTheFouthBackend.Application.Features.Shared; 

public class PaginatedListResponse<T> where T : class
{
    public int CurrentPage { get; set; }
    public int TotalPage { get; set; }
    public int TotalItems { get; set; }
    public IEnumerable<T> Result { get; set; } = Enumerable.Empty<T>();

    public PaginatedListResponse(IEnumerable<T> items, int totalItems, int currentPage, int pageSize)
    {
        CurrentPage = currentPage;
        TotalItems = totalItems;
        TotalPage = (int)Math.Ceiling(totalItems /(double) pageSize);
        Result = items; 
    }
}
