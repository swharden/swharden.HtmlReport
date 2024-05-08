namespace swharden.HtmlReport.Sections;

internal class LineBreak(int count = 1) : ISection
{
    public string GetHtml()
    {
        return string.Join(string.Empty, Enumerable.Repeat("<br>", count));
    }
}
