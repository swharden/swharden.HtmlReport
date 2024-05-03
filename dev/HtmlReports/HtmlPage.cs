using System.Diagnostics;
using System.Text;

namespace HtmlReports;

public class HtmlPage
{
    public string Title { get; set; } = string.Empty;
    public IHtmlTemplate Template { get; set; } = new HtmlTemplates.Bootstrap();

    public List<IHtmlSection> Sections { get; } = [];

    public void AddHeading(string text, int level = 1) =>
        Sections.Add(new HtmlSections.Heading(text, level));

    public void Save(string saveAs, bool launch = false)
    {
        StringBuilder sb = new();
        foreach (var section in Sections)
        {
            sb.AppendLine(section.GetHtml());
        }

        string html = Template.GetHtml()
            .Replace("{{CONTENT}}", sb.ToString())
            .Replace("{{TITLE}}", Title);

        File.WriteAllText(saveAs, html);
        Console.WriteLine($"Saved: {Path.GetFullPath(saveAs)}");

        if (launch)
        {
            ProcessStartInfo psi = new(saveAs) { UseShellExecute = true };
            Process p = new() { StartInfo = psi };
            p.Start();
        }
    }
}
