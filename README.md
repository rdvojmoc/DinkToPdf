# DinkToPdf
.NET Core P/Invoke wrapper for wkhtmltopdf library that uses Webkit engine to convert HTML pages to PDF.

### Install 

Library can be installed through Nuget [here](https://www.nuget.org/packages/RndUsr0.DinkToPdf/). 
Run command bellow from the package manager console:

```
PM> Install-Package RndUsr0.DinkToPdf -Version 1.0.9-20190207.1
```
The package now contains the native libraries for Windows, Linux and MacOS, so it shouldn't be necessary to copy them separately as previously required below. 

Copy native library to root folder of your project. From there .NET Core loads native library when native method is called with P/Invoke. You can find latest version of native library [here](https://github.com/rndusr0/DinkToPdf/tree/master/v0.12.5). Select appropriate library for your OS and platform (64 or 32 bit).

### IMPORTANT

This has now been tested with IIS on Windows Server 2012 R2 and 2016. You will need to install the MS visual C++ 2015 redistributable package available [here](https://www.microsoft.com/en-us/download/details.aspx?id=52685). The library has also been tested in console applications and with Kestrel web server both for Web Application and Web API . 

### 

### Basic converter
Use this converter in single threaded applications.

Create converter:
```csharp
var converter = new BasicConverter(new PdfTools());
```

### Synchronized converter
Use this converter in multi threaded applications and web servers. Conversion tasks are saved to blocking collection and executed on a single thread.

```csharp
var converter = new SynchronizedConverter(new PdfTools());
```

### Define document to convert
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

### Convert
If Out property is empty string (defined in GlobalSettings) result is saved in byte array. 
```csharp
byte[] pdf = converter.Convert(doc);
```

If Out property is defined in document then file is saved to disk:
```csharp
var doc = new HtmlToPdfDocument()
{
    GlobalSettings = {
        ColorMode = ColorMode.Color,
        Orientation = Orientation.Portrait,
        PaperSize = PaperKind.A4,
        Margins = new MarginSettings() { Top = 10 },
        Out = @"C:\DinkToPdf\src\DinkToPdf.TestThreadSafe\test.pdf",
    },
    Objects = {
        new ObjectSettings()
        {
            Page = "http://google.com/",
        },
    }
};
```
```csharp
converter.Convert(doc);
```

### Dependency injection
Converter must be registered as singleton.

```csharp
public void ConfigureServices(IServiceCollection services)
{
    // Add converter to DI
    services.AddSingleton(typeof(IConverter), new SynchronizedConverter(new PdfTools()));
}
```
