namespace swharden.HtmlReport.Sections;

public class Heading(string text, int level) : ISection
{
    public string Text { get; } = text;
    public int Level { get; } = level;

    public string GetHtml()
    {
        return $"<h{Level}>{Text}</h{Level}>";
    }
}
