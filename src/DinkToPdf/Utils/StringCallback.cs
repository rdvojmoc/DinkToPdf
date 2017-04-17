using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace DinkToPdf
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void StringCallback(IntPtr converter, [MarshalAs(UnmanagedType.LPStr)] string str);
}
