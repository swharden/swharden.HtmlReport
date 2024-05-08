namespace swharden.HtmlReport.Sections;

public class Hr() : ISection
{
    public string GetHtml()
    {
        return $"<hr>";
    }
}
