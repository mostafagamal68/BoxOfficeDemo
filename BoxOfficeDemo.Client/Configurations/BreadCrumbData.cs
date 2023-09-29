namespace BoxOfficeDemo.Client.Configurations;

public class BreadCrumbData
{
    public string PageName { get; set; } = "";
    public bool IsAuthorized { get; set; } = false;
    public string? UnAuthorizedPage { get; set; } = null;
}
