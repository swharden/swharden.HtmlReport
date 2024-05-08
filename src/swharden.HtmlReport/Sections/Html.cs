namespace swharden.HtmlReport.Sections;

public class Html(string html) : ISection
{
    public string HTML { get; } = html;

    public string GetHtml() => HTML;
}
