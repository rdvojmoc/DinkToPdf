using DinkToPdf.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinkToPdf
{
    public class ObjectSettings : IObject
    {
        /// <summary>
        /// The URL or path of the web page to convert, if "-" input is read from stdin. Default = ""
        /// </summary>
        [WkHtml("page")]
        public string Page { get; set; }

        /// <summary>
        /// Should external links in the HTML document be converted into external pdf links. Default = true
        /// </summary>
        [WkHtml("useExternalLinks")]
        public bool? UseExternalLinks { get; set; }

        /// <summary>
        /// Should internal links in the HTML document be converted into pdf references. Default = true
        /// </summary>
        [WkHtml("useLocalLinks")]
        public bool? UseLocalLinks { get; set; }

        /// <summary>
        /// Should we turn HTML forms into PDF forms. Default = false
        /// </summary>
        [WkHtml("produceForms")]
        public bool? ProduceForms { get; set; }

        /// <summary>
        /// Should the sections from this document be included in the outline and table of content. Default = false
        /// </summary>
        [WkHtml("includeInOutline")]
        public bool? IncludeInOutline { get; set; }

        /// <summary>
        /// Should we count the pages of this document, in the counter used for TOC, headers and footers. Default = false
        /// </summary>
        [WkHtml("pagesCount")]
        public bool? PagesCount { get; set; }

        public string HtmlContent { get; set; }

        public Encoding Encoding { get; set; }

        private WebSettings webSettings = new WebSettings();

        public WebSettings WebSettings {
            get { return webSettings; }
            set { webSettings = value; }
        }

        private HeaderSettings headerSettings = new HeaderSettings();

        public HeaderSettings HeaderSettings {
            get { return headerSettings; }
            set { headerSettings = value; }
        }

        private FooterSettings footerSettings = new FooterSettings();

        public FooterSettings FooterSettings {
            get { return footerSettings; }
            set { footerSettings = value; }
        }

        private LoadSettings loadSettings = new LoadSettings();

        public LoadSettings LoadSettings {
            get { return loadSettings; }
            set { loadSettings = value; }
        }

        public byte[] GetContent()
        {
            if (HtmlContent == null)
            {
                return new byte[0];
            }

            if (Encoding == null)
            {
                Encoding = Encoding.UTF8;
            }

            return Encoding.GetBytes(HtmlContent);
        }
    }
}
