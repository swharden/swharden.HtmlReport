namespace swharden.HtmlReport.Sections;

public class Paragraph(string text) : ISection
{
    public string Text { get; } = text;

    public string GetHtml()
    {
        return $"<p>{Text}</p>";
    }
}
