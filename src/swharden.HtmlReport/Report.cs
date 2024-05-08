using System.Diagnostics;

namespace swharden.HtmlReport;

public class Report
{
    private readonly Stopwatch SW = Stopwatch.StartNew();
    public List<ISection> Sections { get; } = [];
    public ITemplate Template { get; set; } = new Templates.Bootstrap();
    public string Title { get; set; } = string.Empty;

    public void AddH1(string text) => Sections.Add(new Sections.Heading(text, 1));
    public void AddH2(string text) => Sections.Add(new Sections.Heading(text, 2));
    public void AddH3(string text) => Sections.Add(new Sections.Heading(text, 3));
    public void AddH4(string text) => Sections.Add(new Sections.Heading(text, 4));
    public void AddH5(string text) => Sections.Add(new Sections.Heading(text, 5));
    public void AddH6(string text) => Sections.Add(new Sections.Heading(text, 6));
    public void AddHr() => Sections.Add(new Sections.Hr());
    public void AddHtml(string html) => Sections.Add(new Sections.Html(html));
    public void AddImage(string path, bool embed = true) => Sections.Add(new Sections.Image(path, embed));
    public void AddLineBreak(int count) => Sections.Add(new Sections.LineBreak(count));
    public void AddParagraph(string text) => Sections.Add(new Sections.Paragraph(text));
    public void AddPlot(ScottPlot.Plot plot) => Sections.Add(new Sections.PlotImage(plot));

    public string GetContentHtml()
    {
        return string.Join("\n", Sections.Select(x => x.GetHtml()));
    }

    public string GetHtml()
    {
        return Template.GetHtml()
            .Replace("{{TITLE}}", Title)
            .Replace("{{ELAPSED}}", SW.Elapsed.TotalSeconds.ToString("N2"))
            .Replace("{{DATE}}", DateTime.Now.ToShortDateString())
            .Replace("{{TIME}}", DateTime.Now.ToShortTimeString())
            .Replace("{{CONTENT}}", GetContentHtml());
    }

    public void SaveHtml(string path, bool launch = false)
    {
        path = Path.GetFullPath(path);
        File.WriteAllText(path, GetHtml());
        if (launch)
        {
            System.Diagnostics.Process.Start("explorer.exe", path);
        }
    }
}
