using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinkToPdf.Contracts
{
    public interface IDocument : ISettings
    {
       IEnumerable<IObject> GetObjects();
    }
}
