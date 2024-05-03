using System.Text;

namespace HtmlReports.HtmlSections;

public class DyGraph : IHtmlSection
{
    List<string> ColumnNames { get; } = [];
    List<string[]> ColumnValues { get; } = [];

    public void AddColumn(string name, string[] values)
    {
        ColumnNames.Add(name);
        ColumnValues.Add(values);
    }

    public string GetHtml()
    {
        StringBuilder sb = new();

        foreach (var name in ColumnNames)
        {
            sb.Append($"{name}, ");
        }
        sb.Append("\\n");

        int height = ColumnValues.First().Length;
        int width = ColumnValues.Count;

        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                sb.Append($"{ColumnValues[x][y]}, ");
            }
            sb.Append("\\n");
        }

        return 
            """
            <div id="graphdiv" class="mx-auto my-5"></div>
            <script type="text/javascript">
                Dygraph.onDOMready(function onDOMready() {
                    g1 = new Dygraph(
                        document.getElementById("graphdiv"),
                        "{{DATA}}",
                        {} // the options
                    );
                });
            </script>
            """.Replace("{{DATA}}", sb.ToString());
    }
}
