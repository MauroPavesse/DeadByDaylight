namespace DeadByDaylight.Application.DtosShared;

public class ResponseApi<T>
{
    public List<T> Data { get; set; } = new List<T>();
    public bool Success { get; set; } = false;
    public string Message { get; set; } = string.Empty;
}
