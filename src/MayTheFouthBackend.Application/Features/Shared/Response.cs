using Flunt.Notifications;

namespace MayTheFouthBackend.Application.Features.Shared; 

public abstract class Response
{
    public string Message { get; set; } = string.Empty;
    public int StatusCode { get; set; } = 400;
    public IEnumerable<Notification>? Notifications { get; set; } = Enumerable.Empty<Notification>();
    public bool IsSucess => StatusCode >= 200 && StatusCode <= 299; 

}
