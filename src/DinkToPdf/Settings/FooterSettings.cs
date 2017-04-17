using DinkToPdf.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinkToPdf
{
    public class FooterSettings : ISettings
    {
        /// <summary>
        /// The font size to use for the footer. Default = 12
        /// </summary>
        [WkHtml("footer.fontSize")]
        public int? FontSize { get; set; }

        /// <summary>
        /// The name of the font to use for the footer. Default = "Ariel"
        /// </summary>
        [WkHtml("footer.fontName")]
        public string FontName { get; set; }

        /// <summary>
        /// The string to print in the left part of the footer, note that some sequences are replaced in this string, see the wkhtmltopdf manual. Default = ""
        /// </summary>
        [WkHtml("footer.left")]
        public string Left { get; set; }

        /// <summary>
        /// The text to print in the right part of the footer, note that some sequences are replaced in this string, see the wkhtmltopdf manual. Default = ""
        /// </summary>
        [WkHtml("footer.center")]
        public string Center { get; set; }

        /// <summary>
        /// The text to print in the right part of the footer, note that some sequences are replaced in this string, see the wkhtmltopdf manual. Default = ""
        /// </summary>
        [WkHtml("footer.right")]
        public string Right { get; set; }

        /// <summary>
        /// Whether a line should be printed above the footer. Default = false
        /// </summary>
        [WkHtml("footer.line")]
        public bool? Line { get; set; }

        /// <summary>
        /// The amount of space to put between the footer and the content, e.g. "1.8". Be aware that if this is too large the footer will be printed outside the pdf document. This can be corrected with the margin.bottom setting. Default = 0.00
        /// </summary>
        [WkHtml("footer.spacing")]
        public double? Spacing { get; set; }

        /// <summary>
        /// Url for a HTML document to use for the footer. Default = ""
        /// </summary>
        [WkHtml("footer.htmlUrl")]
        public string HtmUrl { get; set; }
    }
}
