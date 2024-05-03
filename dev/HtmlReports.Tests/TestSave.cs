namespace HtmlReports.Tests;

public class Tests
{
    [Test]
    public void Test_Headings()
    {
        HtmlPage page = new();

        for (int i = 1; i <= 6; i++)
        {
            page.AddHeading($"Heading {i}", i);
        }

        page.Save("test.html");
    }

    [Test]
    public void Test_Graph()
    {
        HtmlSections.DyGraph graph = new();
        double[] xs = [1, 2, 3, 4];
        double[] ys = [1, 4, 9, 16];
        graph.AddColumn("Xs", xs.Select(x => x.ToString()).ToArray());
        graph.AddColumn("Ys", ys.Select(y => y.ToString()).ToArray());

        HtmlPage page = new();
        page.Sections.Add(graph);
        page.Save("test.html");
    }
}