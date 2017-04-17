using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinkToPdf
{
    /// <summary>
    /// This enum "extends" UnmanagedType enum from System.Runtime.InteropServices v4.1.0 which doesn't have LPUTF8Str (enum value is 48) enumartion defined
    /// </summary>
    public enum CustomUnmanagedType
    {
        LPUTF8Str=48
    }
}
