namespace DeadByDaylight.Application.DtosShared;

public class SearchContract
{
    public int Id { get; set; } = 0;
    public string Code { get; set; } = "";
    public string Text { get; set; } = "";

    public List<SearchFilterContract> Filters { get; set; } = new List<SearchFilterContract>();
}

public class SearchFilterContract
{
    public string Field { get; set; } = "";
    public string Value { get; set; } = "";
    public List<int> Ids { get; set; } = new List<int>();
}
