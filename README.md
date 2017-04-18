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

Define document to convert:
```csharp
var converter = new BasicConverter(new PdfTools());
});
```

