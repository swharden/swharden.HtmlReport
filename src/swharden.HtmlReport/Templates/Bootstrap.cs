﻿namespace swharden.HtmlReport.Templates;

public class Bootstrap : ITemplate
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
                <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
              </head>
              <body>
                <div class="container">
                    {{CONTENT}}
                    <footer class='my-5 text-muted'>
                        Generated in {{ELAPSED}} seconds on {{DATE}} at {{TIME}}
                    </footer>
                </div>
                <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
              </body>
            </html>
            """;
    }
}
