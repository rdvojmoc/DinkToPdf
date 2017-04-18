# DinkToPdf
.NET Core P/Invoke wrapper for wkhtmltopdf library that uses Webkit engine to convert HTML pages to PDF.

### Install 

Library can be installed through Nuget. Run command bellow from the package manager console:

```
PM> Install-Package DinkToPdf
```

### Basic converter
Use this converter in single threaded applications.

Create converter:
```csharp
var converter = new BasicConverter(new PdfTools());
});
```

### Define document to convert:
```csharp
var doc = new HtmlToPdfDocument()
{
    GlobalSettings = {
        ColorMode = ColorMode.Color,
        Orientation = Orientation.Landscape,
        PaperSize = PaperKind.A4Plus,
    },
    Objects = {
        new ObjectSettings() {
            PagesCount = true,
            HtmlContent = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. In consectetur mauris eget ultrices  iaculis. Ut                               odio viverra, molestie lectus nec, venenatis turpis.",
            WebSettings = { DefaultEncoding = "utf-8" },
            HeaderSettings = { FontSize = 9, Right = "Page [page] of [toPage]", Line = true, Spacing = 2.812 }
        }
    }
};

```

