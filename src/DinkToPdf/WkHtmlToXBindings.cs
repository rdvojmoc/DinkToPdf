using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace DinkToPdf
{
    public unsafe static class WkHtmlToXBindings
    {
        const string DLLNAME = "libwkhtmltox";

        const CharSet CHARSET = CharSet.Unicode;

        #region HTML to PDF bindings
        [DllImport(DLLNAME, CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern int wkhtmltopdf_extended_qt();
        
        [DllImport(DLLNAME, CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr wkhtmltopdf_version();

        [DllImport(DLLNAME, CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern int wkhtmltopdf_init(int useGraphics);

        [DllImport(DLLNAME, CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern int wkhtmltopdf_deinit();

        [DllImport(DLLNAME, CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr wkhtmltopdf_create_global_settings();

        [DllImport(DLLNAME, CharSet = CHARSET)]
        public static extern int wkhtmltopdf_set_global_setting(IntPtr settings,
            [MarshalAs((short)CustomUnmanagedType.LPUTF8Str)]
            string name,
            [MarshalAs((short)CustomUnmanagedType.LPUTF8Str)]
            string value);


        [DllImport(DLLNAME, CharSet = CHARSET)]
        public static unsafe extern int wkhtmltopdf_get_global_setting(IntPtr settings,
            [MarshalAs((short)CustomUnmanagedType.LPUTF8Str)]
            string name,
            byte* value, int valueSize);

        [DllImport(DLLNAME, CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern int wkhtmltopdf_destroy_global_settings(IntPtr settings);

        [DllImport(DLLNAME, CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr wkhtmltopdf_create_object_settings();

        [DllImport(DLLNAME, CharSet = CHARSET)]
        public static extern int wkhtmltopdf_set_object_setting(IntPtr settings,
            [MarshalAs((short)CustomUnmanagedType.LPUTF8Str)]
            string name,
            [MarshalAs((short)CustomUnmanagedType.LPUTF8Str)]
            string value);

        [DllImport(DLLNAME, CharSet = CHARSET)]
        public static unsafe extern int wkhtmltopdf_get_object_setting(IntPtr settings,
            [MarshalAs((short)CustomUnmanagedType.LPUTF8Str)]
            string name,
            byte* value, int valueSize);
        
        [DllImport(DLLNAME, CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern int wkhtmltopdf_destroy_object_settings(IntPtr settings);

        [DllImport(DLLNAME, CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr wkhtmltopdf_create_converter(IntPtr globalSettings);

        [DllImport(DLLNAME, CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern void wkhtmltopdf_add_object(IntPtr converter, 
            IntPtr objectSettings, 
            byte[] data);
        
        [DllImport(DLLNAME, CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern void wkhtmltopdf_add_object(IntPtr converter,
            IntPtr objectSettings,
            [MarshalAs((short)CustomUnmanagedType.LPUTF8Str)] string data);

        [DllImport(DLLNAME, CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool wkhtmltopdf_convert(IntPtr converter);

        [DllImport(DLLNAME, CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern void wkhtmltopdf_destroy_converter(IntPtr converter);

        [DllImport(DLLNAME, CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern int wkhtmltopdf_get_output(IntPtr converter, out IntPtr data);

        [DllImport(DLLNAME, CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern int wkhtmltopdf_set_phase_changed_callback(IntPtr converter, [MarshalAs(UnmanagedType.FunctionPtr)] VoidCallback callback);

        [DllImport(DLLNAME, CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern int wkhtmltopdf_set_progress_changed_callback(IntPtr converter, [MarshalAs(UnmanagedType.FunctionPtr)] VoidCallback callback);

        [DllImport(DLLNAME, CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern int wkhtmltopdf_set_finished_callback(IntPtr converter, [MarshalAs(UnmanagedType.FunctionPtr)] IntCallback callback);

        [DllImport(DLLNAME, CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern int wkhtmltopdf_set_warning_callback(IntPtr converter, [MarshalAs(UnmanagedType.FunctionPtr)] StringCallback callback);

        [DllImport(DLLNAME, CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern int wkhtmltopdf_set_error_callback(IntPtr converter, [MarshalAs(UnmanagedType.FunctionPtr)] StringCallback callback);

        [DllImport(DLLNAME, CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern int wkhtmltopdf_phase_count(IntPtr converter);

        [DllImport(DLLNAME, CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern int wkhtmltopdf_current_phase(IntPtr converter);

        [DllImport(DLLNAME, CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr wkhtmltopdf_phase_description(IntPtr converter, int phase);

        [DllImport(DLLNAME, CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr wkhtmltopdf_progress_string(IntPtr converter);

        [DllImport(DLLNAME, CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern int wkhtmltopdf_http_error_code(IntPtr converter);

        #endregion

        #region Image to  PDF bindings


        #endregion
    }
}
