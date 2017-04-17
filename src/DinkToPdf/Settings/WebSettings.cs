using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DinkToPdf.Contracts;

namespace DinkToPdf
{
    public class WebSettings : ISettings
    {
        /// <summary>
        /// Should we print the background. Default = true
        /// </summary>
        [WkHtml("web.background")]
        public bool? Background { get; set; }

        /// <summary>
        /// Should we load images. Default = true
        /// </summary>
        [WkHtml("web.loadImages")]
        public bool? LoadImages { get; set; }

        /// <summary>
        /// Should we enable javascript. Default = true
        /// </summary>
        [WkHtml("web.enableJavascript")]
        public bool? EnableJavascript { get; set; }

        /// <summary>
        /// Should we enable intelligent shrinkng to fit more content on one page. Has no effect for wkhtmltoimage. Default = true
        /// </summary>
        [WkHtml("web.enableIntelligentShrinking")]
        public bool? EnableIntelligentShrinking { get; set; }

        /// <summary>
        /// The minimum font size allowed. Default = -1
        /// </summary>
        [WkHtml("web.minimumFontSize")]
        public int? MinimumFontSize { get; set; }

        /// <summary>
        /// Should the content be printed using the print media type instead of the screen media type. Default = false
        /// </summary>
        [WkHtml("web.printMediaType")]
        public bool? PrintMediaType { get; set; }

        /// <summary>
        /// What encoding should we guess content is using if they do not specify it properly. Default = ""
        /// </summary>
        [WkHtml("web.defaultEncoding")]
        public string DefaultEncoding { get; set; }

        /// <summary>
        /// Url or path to a user specified style sheet. Default = ""
        /// </summary>
        [WkHtml("web.userStyleSheet")]
        public string UserStyleSheet { get; set; }

        /// <summary>
        /// Should we enable NS plugins. Enabling this will have limited success. Default = false
        /// </summary>
        [WkHtml("web.enablePlugins")]
        public bool? enablePlugins { get; set; }
    }
}
