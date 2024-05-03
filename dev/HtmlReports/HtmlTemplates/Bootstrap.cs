﻿namespace HtmlReports.HtmlTemplates;

public class Bootstrap : IHtmlTemplate
{
    public string GetHtml()
    {
        return
        """
        <!doctype html>
        <html lang="en">
          <head>
            <meta charset="utf-8">
            <meta name="viewport" content="width=device-width, initial-scale=1">
            <title>{{TITLE}}</title>
            <script type="text/javascript" src="https://unpkg.com/dygraphs@2.2.1/dist/dygraph.min.js"></script>
            <link rel="stylesheet" type="text/css" href="https://unpkg.com/dygraphs@2.2.1/dist/dygraph.min.css" />
            <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
          </head>
          <body>{{CONTENT}}
            <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
          </body>
        </html>
        """;
    }
}