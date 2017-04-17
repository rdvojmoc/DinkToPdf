using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DinkToPdf.Contracts;

namespace DinkToPdf.EventDefinitions
{
    public class ProgressChangedArgs : EventArgs
    {
        public IDocument Document { get; set; }

        public string Description { get; set; }
    }
}
