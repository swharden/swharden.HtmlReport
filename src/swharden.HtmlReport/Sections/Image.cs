namespace swharden.HtmlReport.Sections;

public class Image(string path, bool embed) : ISection
{
    public string Path { get; } = path;
    public bool Embed { get; } = embed;

    public string GetHtml()
    {
        return $"<a href='{Path}'><img src='{Path}' class='mw-100'></a>";
    }
}
