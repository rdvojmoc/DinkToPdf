using DinkToPdf.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinkToPdf
{
    public enum ColorMode
    {
        Color,
        Grayscale
    }

    public enum Orientation
    {
        Landscape,
        Portrait
    }

    public class GlobalSettings : ISettings
    {
        

        private MarginSettings margins = new MarginSettings();

        /// <summary>
        /// The orientation of the output document, must be either "Landscape" or "Portrait". Default = "portrait"
        /// </summary>
        [WkHtml("orientation")]
        public Orientation? Orientation { get; set; }

        /// <summary>
        /// Should the output be printed in color or gray scale, must be either "Color" or "Grayscale". Default = "color"
        /// </summary>
        [WkHtml("colorMode")]
        public ColorMode? ColorMode { get; set; }

        /// <summary>
        /// Should we use loss less compression when creating the pdf file. Default = true
        /// </summary>
        [WkHtml("useCompression")]
        public bool? UseCompression { get; set; }

        /// <summary>
        /// What dpi should we use when printing. Default = 96
        /// </summary>
        [WkHtml("dpi")]
        public int? DPI { get; set; }

        /// <summary>
        /// A number that is added to all page numbers when printing headers, footers and table of content. Default = 0
        /// </summary>
        [WkHtml("pageOffset")]
        public int? PageOffset { get; set; }

        /// <summary>
        /// How many copies should we print. Default = 1
        /// </summary>
        [WkHtml("copies")]
        public int? Copies { get; set; }

        /// <summary>
        /// Should the copies be collated. Default = true
        /// </summary>
        [WkHtml("collate")]
        public bool? Collate { get; set; }

        /// <summary>
        /// Should a outline (table of content in the sidebar) be generated and put into the PDF. Default = true
        /// </summary>
        [WkHtml("outline")]
        public bool? Outline { get; set; }

        /// <summary>
        /// The maximal depth of the outline. Default = 4
        /// </summary>
        [WkHtml("outlineDepth")]
        public int? OutlineDepth { get; set; }

        /// <summary>
        /// If not set to the empty string a XML representation of the outline is dumped to this file. Default = ""
        /// </summary>
        [WkHtml("dumpOutline")]
        public string DumpOutline { get; set; }

        /// <summary>
        /// The path of the output file, if "-" output is sent to stdout, if empty the output is stored in a buffer. Default = ""
        /// </summary>
        [WkHtml("out")]
        public string Out { get; set; }

        /// <summary>
        /// The title of the PDF document. Default = ""
        /// </summary>
        [WkHtml("documentTitle")]
        public string DocumentTitle { get; set; }

        /// <summary>
        /// The maximal DPI to use for images in the pdf document. Default = 600
        /// </summary>
        [WkHtml("imageDPI")]
        public int? ImageDPI { get; set; }

        /// <summary>
        /// The jpeg compression factor to use when producing the pdf document. Default = 94
        /// </summary>
        [WkHtml("imageQuality")]
        public int? ImageQuality { get; set; }

        /// <summary>
        /// Path of file used to load and store cookies. Default = ""
        /// </summary>
        [WkHtml("load.cookieJar")]
        public string CookieJar { get; set; }

        /// <summary>
        /// Size of output paper
        /// </summary>
        public PechkinPaperSize PaperSize { get; set; }

        /// <summary>
        /// The height of the output document
        /// </summary>
        [WkHtml("size.height")]
        private string PaperHeight
        {
            get {
                return PaperSize == null ? null : PaperSize.Height;
            }
        }
        
        /// <summary>
        /// The width of the output document
        /// </summary>
        [WkHtml("size.width")]
        private string PaperWidth
        {
            get
            {
                return PaperSize == null ? null : PaperSize.Width;
            }
        }

        public MarginSettings Margins
        {
            get {
                return this.margins;
            }
            set {
                margins = value;
            }
        }

        /// <summary>
        /// Size of the left margin
        /// </summary>
        [WkHtml("margin.left")]
        private string MarginLeft
        {
            get {
                return margins.GetMarginValue(margins.Left);
            }
        }

        /// <summary>
        /// Size of the right margin
        /// </summary>
        [WkHtml("margin.right")]
        private string MarginRight
        {
            get
            {
                return margins.GetMarginValue(margins.Right);
            }
        }

        /// <summary>
        /// Size of the top margin
        /// </summary>
        [WkHtml("margin.top")]
        private string MarginTop
        {
            get
            {
                return margins.GetMarginValue(margins.Top);
            }
        }

        /// <summary>
        /// Size of the bottom margin
        /// </summary>
        [WkHtml("margin.bottom")]
        private string MarginBottom
        {
            get
            {
                return margins.GetMarginValue(margins.Bottom);
            }
        }

        /// <summary>
        /// Set viewport size. Not supported in wkhtmltopdf API since v0.12.2.4 
        /// </summary>
        [WkHtml("viewportSize")]
        public string ViewportSize { get; set; }
    }
}
