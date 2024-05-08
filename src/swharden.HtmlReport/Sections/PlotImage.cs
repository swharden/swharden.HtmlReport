namespace swharden.HtmlReport.Sections;

internal class PlotImage : ISection
{
    public readonly string Html;

    public PlotImage(ScottPlot.Plot plot, int width = 600, int height = 400)
    {
        byte[] bytes = plot.GetImageBytes(width, height, ScottPlot.ImageFormat.Png);
        string b64 = Convert.ToBase64String(bytes);
        Html = $"<img src=\"data:image/png;base64,{b64}\" />";
    }

    public string GetHtml() => Html;
}
