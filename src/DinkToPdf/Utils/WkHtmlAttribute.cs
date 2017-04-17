using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinkToPdf
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class WkHtmlAttribute : Attribute
    {
        public string Name { get; private set; }

        public WkHtmlAttribute(string name)
        {
            Name = name;
        }
    }
}
