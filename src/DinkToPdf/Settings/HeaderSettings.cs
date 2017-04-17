using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DinkToPdf.Contracts;

namespace DinkToPdf
{
    public class HeaderSettings : ISettings
    {
        /// <summary>
        /// The font size to use for the header. Default = 12
        /// </summary>
        [WkHtml("header.fontSize")]
        public int? FontSize { get; set; }

        /// <summary>
        /// The name of the font to use for the header. Default = "Ariel"
        /// </summary>
        [WkHtml("header.fontName")]
        public string FontName { get; set; }

        /// <summary>
        /// The string to print in the left part of the header, note that some sequences are replaced in this string, see the wkhtmltopdf manual. Default = ""
        /// </summary>
        [WkHtml("header.left")]
        public string Left { get; set; }

        /// <summary>
        /// The text to print in the right part of the header, note that some sequences are replaced in this string, see the wkhtmltopdf manual. Default = ""
        /// </summary>
        [WkHtml("header.center")]
        public string Center { get; set; }

        /// <summary>
        /// The text to print in the right part of the header, note that some sequences are replaced in this string, see the wkhtmltopdf manual. Default = ""
        /// </summary>
        [WkHtml("header.right")]
        public string Right { get; set; }

        /// <summary>
        /// Whether a line should be printed under the header. Default = false
        /// </summary>
        [WkHtml("header.line")]
        public bool? Line { get; set; }

        /// <summary>
        /// The amount of space to put between the header and the content, e.g. "1.8". Be aware that if this is too large the header will be printed outside the pdf document. This can be corrected with the margin.top setting. Default = 0.00
        /// </summary>
        [WkHtml("header.spacing")]
        public double? Spacing { get; set; }

        /// <summary>
        /// Url for a HTML document to use for the header. Default = ""
        /// </summary>
        [WkHtml("header.htmlUrl")]
        public string HtmUrl { get; set; }
    }
}
