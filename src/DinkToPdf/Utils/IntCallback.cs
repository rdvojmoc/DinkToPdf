using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace DinkToPdf
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void IntCallback(IntPtr converter, int integer);
}
