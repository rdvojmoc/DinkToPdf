using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DinkToPdf.Contracts;

namespace DinkToPdf
{
    public enum ContentErrorHandling
    {
        Abort,
        Skip,
        Ignore
    }

    public class LoadSettings : ISettings
    {
        /// <summary>
        /// The user name to use when loging into a website. Default = ""
        /// </summary>
        [WkHtml("load.username")]
        public string Username { get; set; }

        /// <summary>
        /// The password to used when logging into a website. Default = ""
        /// </summary>
        [WkHtml("load.password")]
        public string Password { get; set; }

        /// <summary>
        /// The mount of time in milliseconds to wait after a page has done loading until it is actually printed. E.g. "1200". We will wait this amount of time or until, javascript calls window.print(). Default = 200
        /// </summary>
        [WkHtml("load.jsdelay")]
        public int? JSDelay { get; set; }

        /// <summary>
        /// How much should we zoom in on the content. Default = 1.0
        /// </summary>
        [WkHtml("load.zoomFactor")]
        public double? ZoomFactor { get; set; }

        /// <summary>
        /// Disallow local and piped files to access other local files. Default = false
        /// </summary>
        [WkHtml("load.blockLocalFileAccess")]
        public bool? BlockLocalFileAccess { get; set; }

        /// <summary>
        /// Stop slow running javascript. Default = true
        /// </summary>
        [WkHtml("load.stopSlowScript")]
        public bool? StopSlowScript { get; set; }

        /// <summary>
        /// Forward javascript warnings and errors to the warning callback. Default = false
        /// </summary>
        [WkHtml("load.debugJavascript")]
        public bool? DebugJavascript { get; set; }

        /// <summary>
        /// How should we handle obejcts that fail to load. Default = Abort
        /// </summary>
        [WkHtml("load.loadErrorHandling")]
        public ContentErrorHandling? LoadErrorHandling { get; set; }

        /// <summary>
        /// String describing what proxy to use when loading the object. Default = ""
        /// </summary>
        [WkHtml("load.proxy")]
        public string Proxy { get; set; }

        /// <summary>
        /// Custom headers used when requesting page. Defaulty = empty
        /// </summary>
        [WkHtml("load.customHeaders")]
        public Dictionary<string, string> CustomHeaders { get; set; }

        /// <summary>
        /// Should the custom headers be sent all elements loaded instead of only the main page. Default = false
        /// </summary>
        [WkHtml("load.repeatCustomHeaders")]
        public bool? RepeatCustomHeaders { get; set; }

        /// <summary>
        /// Cookies used when requesting page. Default = empty
        /// </summary>
        [WkHtml("load.cookies")]
        public Dictionary<string, string> Cookies { get; set; }
    }
}
