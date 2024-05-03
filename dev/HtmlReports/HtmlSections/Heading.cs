namespace HtmlReports.HtmlSections;

public class Heading(string text, int level) : IHtmlSection
{
    public int Level { get; } = level;
    public string Text { get; } = text;

    public string GetHtml()
    {
        return $"<h{Level}>{Text}</h{Level}>";
    }
}
