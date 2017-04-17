using System;
using System.Collections.Generic;
using System.Linq;

namespace DinkToPdf.Contracts
{
    public interface IObject : ISettings
    {
        byte[] GetContent();
    }
}
