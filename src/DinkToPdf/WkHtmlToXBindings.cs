using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace DinkToPdf
{
    public unsafe static class WkHtmlToXBindings
    {
        const string DLLNAMEx86 = @"32 bit\libwkhtmltox";
        const string DLLNAMEx64 = @"64 bit\libwkhtmltox";

        static bool isWin32 = Marshal.SizeOf<IntPtr>() == 4;
        const CharSet CHARSET = CharSet.Unicode;

        #region x64 or x86

        public static int wkhtmltopdf_extended_qt()
        {
            if (isWin32)
                return wkhtmltopdf_extended_qt_x86();
            else
                return wkhtmltopdf_extended_qt_x64();
        }

        public static IntPtr wkhtmltopdf_version()
        {
            if (isWin32)
                return wkhtmltopdf_version_x86();
            else
                return wkhtmltopdf_version_x64();
        }

        public static int wkhtmltopdf_init(int useGraphics)
        {
            if (isWin32)
                return wkhtmltopdf_init_x86(useGraphics);
            else
                return wkhtmltopdf_init_x64(useGraphics);
        }

        public static int wkhtmltopdf_deinit()
        {
            if (isWin32)
                return wkhtmltopdf_deinit_x86();
            else
                return wkhtmltopdf_deinit_x64();
        }

        public static IntPtr wkhtmltopdf_create_global_settings()
        {
            if (isWin32)
                return wkhtmltopdf_create_global_settings_x86();
            else
                return wkhtmltopdf_create_global_settings_x64();
        }

        public static int wkhtmltopdf_set_global_setting(IntPtr settings, string name, string value)
        {
            if (isWin32)
                return wkhtmltopdf_set_global_setting_x86(settings, name, value);
            else
                return wkhtmltopdf_set_global_setting_x64(settings, name, value);
        }

        public static unsafe int wkhtmltopdf_get_global_setting(IntPtr settings, string name, byte* value, int valueSize)
        {
            if (isWin32)
                return wkhtmltopdf_get_global_setting_x86(settings, name, value, valueSize);
            else
                return wkhtmltopdf_get_global_setting_x64(settings, name, value, valueSize);
        }

        public static int wkhtmltopdf_destroy_global_settings(IntPtr settings)
        {
            if (isWin32)
                return wkhtmltopdf_destroy_global_settings_x86(settings);
            else
                return wkhtmltopdf_destroy_global_settings_x64(settings);
        }

        public static IntPtr wkhtmltopdf_create_object_settings()
        {
            if (isWin32)
                return wkhtmltopdf_create_object_settings_x86();
            else
                return wkhtmltopdf_create_object_settings_x64();
        }

        public static int wkhtmltopdf_set_object_setting(IntPtr settings, string name, string value)
        {
            if (isWin32)
                return wkhtmltopdf_set_object_setting_x86(settings, name, value);
            else
                return wkhtmltopdf_set_object_setting_x64(settings, name, value);
        }

        public static unsafe int wkhtmltopdf_get_object_setting(IntPtr settings, string name, byte* value, int valueSize)
        {
            if (isWin32)
                return wkhtmltopdf_get_object_setting_x86(settings, name, value, valueSize);
            else
                return wkhtmltopdf_get_object_setting_x64(settings, name, value, valueSize);
        }

        public static int wkhtmltopdf_destroy_object_settings(IntPtr settings)
        {
            if (isWin32)
                return wkhtmltopdf_destroy_object_settings_x86(settings);
            else
                return wkhtmltopdf_destroy_object_settings_x64(settings);
        }

        public static IntPtr wkhtmltopdf_create_converter(IntPtr globalSettings)
        {
            if (isWin32)
                return wkhtmltopdf_create_converter_x86(globalSettings);
            else
                return wkhtmltopdf_create_converter_x64(globalSettings);
        }

        public static void wkhtmltopdf_add_object(IntPtr converter, IntPtr objectSettings, byte[] data)
        {
            if (isWin32)
                wkhtmltopdf_add_object_x86(converter, objectSettings, data);
            else
                wkhtmltopdf_add_object_x64(converter, objectSettings, data);
        }

        public static void wkhtmltopdf_add_object(IntPtr converter, IntPtr objectSettings, string data)
        {
            if (isWin32)
                wkhtmltopdf_add_object_x86(converter, objectSettings, data);
            else
                wkhtmltopdf_add_object_x64(converter, objectSettings, data);
        }

        public static bool wkhtmltopdf_convert(IntPtr converter)
        {
            if (isWin32)
                return wkhtmltopdf_convert_x86(converter);
            else
                return wkhtmltopdf_convert_x64(converter);
        }

        public static void wkhtmltopdf_destroy_converter(IntPtr converter)
        {
            if (isWin32)
                wkhtmltopdf_destroy_converter_x86(converter);
            else
                wkhtmltopdf_destroy_converter_x64(converter);
        }

        public static int wkhtmltopdf_get_output(IntPtr converter, out IntPtr data)
        {
            if (isWin32)
                return wkhtmltopdf_get_output_x86(converter, out data);
            else
                return wkhtmltopdf_get_output_x64(converter, out data);
        }

        public static int wkhtmltopdf_set_phase_changed_callback(IntPtr converter, VoidCallback callback)
        {
            if (isWin32)
                return wkhtmltopdf_set_phase_changed_callback_x86(converter, callback);
            else
                return wkhtmltopdf_set_phase_changed_callback_x64(converter, callback);
        }

        public static int wkhtmltopdf_set_progress_changed_callback(IntPtr converter, VoidCallback callback)
        {
            if (isWin32)
                return wkhtmltopdf_set_progress_changed_callback_x86(converter, callback);
            else
                return wkhtmltopdf_set_progress_changed_callback_x64(converter, callback);
        }

        public static int wkhtmltopdf_set_finished_callback(IntPtr converter, IntCallback callback)
        {
            if (isWin32)
                return wkhtmltopdf_set_finished_callback_x86(converter, callback);
            else
                return wkhtmltopdf_set_finished_callback_x64(converter, callback);
        }

        public static int wkhtmltopdf_set_warning_callback(IntPtr converter, StringCallback callback)
        {
            if (isWin32)
                return wkhtmltopdf_set_warning_callback_x86(converter, callback);
            else
                return wkhtmltopdf_set_warning_callback_x64(converter, callback);
        }

        public static int wkhtmltopdf_set_error_callback(IntPtr converter, StringCallback callback)
        {
            if (isWin32)
                return wkhtmltopdf_set_error_callback_x86(converter, callback);
            else
                return wkhtmltopdf_set_error_callback_x64(converter, callback);
        }

        public static int wkhtmltopdf_phase_count(IntPtr converter)
        {
            if (isWin32)
                return wkhtmltopdf_phase_count_x86(converter);
            else
                return wkhtmltopdf_phase_count_x64(converter);
        }

        public static int wkhtmltopdf_current_phase(IntPtr converter)
        {
            if (isWin32)
                return wkhtmltopdf_current_phase_x86(converter);
            else
                return wkhtmltopdf_current_phase_x64(converter);
        }

        public static IntPtr wkhtmltopdf_phase_description(IntPtr converter, int phase)
        {
            if (isWin32)
                return wkhtmltopdf_phase_description_x86(converter, phase);
            else
                return wkhtmltopdf_phase_description_x64(converter, phase);
        }

        public static IntPtr wkhtmltopdf_progress_string(IntPtr converter)
        {
            if (isWin32)
                return wkhtmltopdf_progress_string_x86(converter);
            else
                return wkhtmltopdf_progress_string_x64(converter);
        }

        public static int wkhtmltopdf_http_error_code(IntPtr converter)
        {
            if (isWin32)
                return wkhtmltopdf_http_error_code_x86(converter);
            else
                return wkhtmltopdf_http_error_code_x64(converter);
        }

        #endregion

        #region HTML to PDF bindings

        #region wkhtmltopdf_extended_qt
        [DllImport(DLLNAMEx86, EntryPoint = "wkhtmltopdf_extended_qt", CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern int wkhtmltopdf_extended_qt_x86();

        [DllImport(DLLNAMEx64, EntryPoint = "wkhtmltopdf_extended_qt", CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern int wkhtmltopdf_extended_qt_x64();
        #endregion

        #region wkhtmltopdf_version
        [DllImport(DLLNAMEx86, EntryPoint = "wkhtmltopdf_version", CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr wkhtmltopdf_version_x86();

        [DllImport(DLLNAMEx64, EntryPoint = "wkhtmltopdf_version", CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr wkhtmltopdf_version_x64();
        #endregion

        #region wkhtmltopdf_init
        [DllImport(DLLNAMEx86, EntryPoint = "wkhtmltopdf_init", CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern int wkhtmltopdf_init_x86(int useGraphics);

        [DllImport(DLLNAMEx64, EntryPoint = "wkhtmltopdf_init", CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern int wkhtmltopdf_init_x64(int useGraphics);
        #endregion

        #region wkhtmltopdf_deinit
        [DllImport(DLLNAMEx86, EntryPoint = "wkhtmltopdf_deinit", CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern int wkhtmltopdf_deinit_x86();

        [DllImport(DLLNAMEx64, EntryPoint = "wkhtmltopdf_deinit", CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern int wkhtmltopdf_deinit_x64();
        #endregion

        #region wkhtmltopdf_create_global_settings
        [DllImport(DLLNAMEx86, EntryPoint = "wkhtmltopdf_create_global_settings", CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr wkhtmltopdf_create_global_settings_x86();

        [DllImport(DLLNAMEx64, EntryPoint = "wkhtmltopdf_create_global_settings", CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr wkhtmltopdf_create_global_settings_x64();
        #endregion

        #region wkhtmltopdf_set_global_setting
        [DllImport(DLLNAMEx86, EntryPoint = "wkhtmltopdf_set_global_setting", CharSet = CHARSET)]
        public static extern int wkhtmltopdf_set_global_setting_x86(IntPtr settings,
            [MarshalAs((short)CustomUnmanagedType.LPUTF8Str)]
            string name,
            [MarshalAs((short)CustomUnmanagedType.LPUTF8Str)]
            string value);

        [DllImport(DLLNAMEx64, EntryPoint = "wkhtmltopdf_set_global_setting", CharSet = CHARSET)]
        public static extern int wkhtmltopdf_set_global_setting_x64(IntPtr settings,
            [MarshalAs((short)CustomUnmanagedType.LPUTF8Str)]
            string name,
            [MarshalAs((short)CustomUnmanagedType.LPUTF8Str)]
            string value);

        #endregion

        #region wkhtmltopdf_get_global_setting
        [DllImport(DLLNAMEx86, EntryPoint = "wkhtmltopdf_get_global_setting", CharSet = CHARSET)]
        public static unsafe extern int wkhtmltopdf_get_global_setting_x86(IntPtr settings,
            [MarshalAs((short)CustomUnmanagedType.LPUTF8Str)]
            string name,
            byte* value, int valueSize);

        [DllImport(DLLNAMEx64, EntryPoint = "wkhtmltopdf_get_global_setting", CharSet = CHARSET)]
        public static unsafe extern int wkhtmltopdf_get_global_setting_x64(IntPtr settings,
            [MarshalAs((short)CustomUnmanagedType.LPUTF8Str)]
            string name,
            byte* value, int valueSize);
        #endregion

        #region wkhtmltopdf_destroy_global_settings
        [DllImport(DLLNAMEx86, EntryPoint = "wkhtmltopdf_destroy_global_settings", CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern int wkhtmltopdf_destroy_global_settings_x86(IntPtr settings);

        [DllImport(DLLNAMEx64, EntryPoint = "wkhtmltopdf_destroy_global_settings", CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern int wkhtmltopdf_destroy_global_settings_x64(IntPtr settings);
        #endregion

        #region wkhtmltopdf_create_object_settings
        [DllImport(DLLNAMEx86, EntryPoint = "wkhtmltopdf_create_object_settings", CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr wkhtmltopdf_create_object_settings_x86();

        [DllImport(DLLNAMEx64, EntryPoint = "wkhtmltopdf_create_object_settings", CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr wkhtmltopdf_create_object_settings_x64();
        #endregion

        #region wkhtmltopdf_set_object_setting
        [DllImport(DLLNAMEx86, EntryPoint = "wkhtmltopdf_set_object_setting", CharSet = CHARSET)]
        public static extern int wkhtmltopdf_set_object_setting_x86(IntPtr settings,
            [MarshalAs((short)CustomUnmanagedType.LPUTF8Str)]
            string name,
            [MarshalAs((short)CustomUnmanagedType.LPUTF8Str)]
            string value);

        [DllImport(DLLNAMEx64, EntryPoint = "wkhtmltopdf_set_object_setting", CharSet = CHARSET)]
        public static extern int wkhtmltopdf_set_object_setting_x64(IntPtr settings,
            [MarshalAs((short)CustomUnmanagedType.LPUTF8Str)]
            string name,
            [MarshalAs((short)CustomUnmanagedType.LPUTF8Str)]
            string value);
        #endregion

        #region wkhtmltopdf_get_object_setting
        [DllImport(DLLNAMEx86, EntryPoint = "wkhtmltopdf_get_object_setting", CharSet = CHARSET)]
        public static unsafe extern int wkhtmltopdf_get_object_setting_x86(IntPtr settings,
            [MarshalAs((short)CustomUnmanagedType.LPUTF8Str)]
            string name,
            byte* value, int valueSize);

        [DllImport(DLLNAMEx64, EntryPoint = "wkhtmltopdf_get_object_setting", CharSet = CHARSET)]
        public static unsafe extern int wkhtmltopdf_get_object_setting_x64(IntPtr settings,
            [MarshalAs((short)CustomUnmanagedType.LPUTF8Str)]
            string name,
            byte* value, int valueSize);
        #endregion

        #region wkhtmltopdf_destroy_object_settings
        [DllImport(DLLNAMEx86, EntryPoint = "wkhtmltopdf_destroy_object_settings", CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern int wkhtmltopdf_destroy_object_settings_x86(IntPtr settings);

        [DllImport(DLLNAMEx64, EntryPoint = "wkhtmltopdf_destroy_object_settings", CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern int wkhtmltopdf_destroy_object_settings_x64(IntPtr settings);
        #endregion

        #region wkhtmltopdf_create_converter
        [DllImport(DLLNAMEx86, EntryPoint = "wkhtmltopdf_create_converter", CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr wkhtmltopdf_create_converter_x86(IntPtr globalSettings);

        [DllImport(DLLNAMEx64, EntryPoint = "wkhtmltopdf_create_converter", CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr wkhtmltopdf_create_converter_x64(IntPtr globalSettings);
        #endregion

        #region wkhtmltopdf_add_object
        [DllImport(DLLNAMEx86, EntryPoint = "wkhtmltopdf_add_object", CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern void wkhtmltopdf_add_object_x86(IntPtr converter,
            IntPtr objectSettings,
            byte[] data);

        [DllImport(DLLNAMEx64, EntryPoint = "wkhtmltopdf_add_object", CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern void wkhtmltopdf_add_object_x64(IntPtr converter,
            IntPtr objectSettings,
            byte[] data);
        #endregion

        #region wkhtmltopdf_add_object
        [DllImport(DLLNAMEx86, EntryPoint = "wkhtmltopdf_add_object", CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern void wkhtmltopdf_add_object_x86(IntPtr converter,
            IntPtr objectSettings,
            [MarshalAs((short)CustomUnmanagedType.LPUTF8Str)] string data);

        [DllImport(DLLNAMEx64, EntryPoint = "wkhtmltopdf_add_object", CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern void wkhtmltopdf_add_object_x64(IntPtr converter,
            IntPtr objectSettings,
            [MarshalAs((short)CustomUnmanagedType.LPUTF8Str)] string data);
        #endregion

        #region wkhtmltopdf_convert
        [DllImport(DLLNAMEx86, EntryPoint = "wkhtmltopdf_convert", CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool wkhtmltopdf_convert_x86(IntPtr converter);

        [DllImport(DLLNAMEx64, EntryPoint = "wkhtmltopdf_convert", CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool wkhtmltopdf_convert_x64(IntPtr converter);
        #endregion

        #region wkhtmltopdf_destroy_converter
        [DllImport(DLLNAMEx86, EntryPoint = "wkhtmltopdf_destroy_converter", CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern void wkhtmltopdf_destroy_converter_x86(IntPtr converter);

        [DllImport(DLLNAMEx64, EntryPoint = "wkhtmltopdf_destroy_converter", CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern void wkhtmltopdf_destroy_converter_x64(IntPtr converter);
        #endregion

        #region wkhtmltopdf_get_output
        [DllImport(DLLNAMEx86, EntryPoint = "wkhtmltopdf_get_output", CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern int wkhtmltopdf_get_output_x86(IntPtr converter, out IntPtr data);

        [DllImport(DLLNAMEx64, EntryPoint = "wkhtmltopdf_get_output", CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern int wkhtmltopdf_get_output_x64(IntPtr converter, out IntPtr data);
        #endregion

        #region wkhtmltopdf_set_phase_changed_callback
        [DllImport(DLLNAMEx86, EntryPoint = "wkhtmltopdf_set_phase_changed_callback", CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern int wkhtmltopdf_set_phase_changed_callback_x86(IntPtr converter, [MarshalAs(UnmanagedType.FunctionPtr)] VoidCallback callback);

        [DllImport(DLLNAMEx64, EntryPoint = "wkhtmltopdf_set_phase_changed_callback", CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern int wkhtmltopdf_set_phase_changed_callback_x64(IntPtr converter, [MarshalAs(UnmanagedType.FunctionPtr)] VoidCallback callback);
        #endregion

        #region wkhtmltopdf_set_progress_changed_callback
        [DllImport(DLLNAMEx86, EntryPoint = "wkhtmltopdf_set_progress_changed_callback", CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern int wkhtmltopdf_set_progress_changed_callback_x86(IntPtr converter, [MarshalAs(UnmanagedType.FunctionPtr)] VoidCallback callback);

        [DllImport(DLLNAMEx64, EntryPoint = "wkhtmltopdf_set_progress_changed_callback", CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern int wkhtmltopdf_set_progress_changed_callback_x64(IntPtr converter, [MarshalAs(UnmanagedType.FunctionPtr)] VoidCallback callback);
        #endregion

        #region wkhtmltopdf_set_finished_callback
        [DllImport(DLLNAMEx86, EntryPoint = "wkhtmltopdf_set_finished_callback", CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern int wkhtmltopdf_set_finished_callback_x86(IntPtr converter, [MarshalAs(UnmanagedType.FunctionPtr)] IntCallback callback);

        [DllImport(DLLNAMEx64, EntryPoint = "wkhtmltopdf_set_finished_callback", CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern int wkhtmltopdf_set_finished_callback_x64(IntPtr converter, [MarshalAs(UnmanagedType.FunctionPtr)] IntCallback callback);
        #endregion

        #region wkhtmltopdf_set_warning_callback
        [DllImport(DLLNAMEx86, EntryPoint = "wkhtmltopdf_set_warning_callback", CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern int wkhtmltopdf_set_warning_callback_x86(IntPtr converter, [MarshalAs(UnmanagedType.FunctionPtr)] StringCallback callback);

        [DllImport(DLLNAMEx64, EntryPoint = "wkhtmltopdf_set_warning_callback", CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern int wkhtmltopdf_set_warning_callback_x64(IntPtr converter, [MarshalAs(UnmanagedType.FunctionPtr)] StringCallback callback);
        #endregion

        #region wkhtmltopdf_set_error_callback
        [DllImport(DLLNAMEx86, EntryPoint = "wkhtmltopdf_set_error_callback", CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern int wkhtmltopdf_set_error_callback_x86(IntPtr converter, [MarshalAs(UnmanagedType.FunctionPtr)] StringCallback callback);

        [DllImport(DLLNAMEx64, EntryPoint = "wkhtmltopdf_set_error_callback", CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern int wkhtmltopdf_set_error_callback_x64(IntPtr converter, [MarshalAs(UnmanagedType.FunctionPtr)] StringCallback callback);
        #endregion

        #region wkhtmltopdf_phase_count
        [DllImport(DLLNAMEx86, EntryPoint = "wkhtmltopdf_phase_count", CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern int wkhtmltopdf_phase_count_x86(IntPtr converter);

        [DllImport(DLLNAMEx64, EntryPoint = "wkhtmltopdf_phase_count", CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern int wkhtmltopdf_phase_count_x64(IntPtr converter);
        #endregion

        #region wkhtmltopdf_current_phase
        [DllImport(DLLNAMEx86, EntryPoint = "wkhtmltopdf_current_phase", CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern int wkhtmltopdf_current_phase_x86(IntPtr converter);

        [DllImport(DLLNAMEx64, EntryPoint = "wkhtmltopdf_current_phase", CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern int wkhtmltopdf_current_phase_x64(IntPtr converter);
        #endregion

        #region wkhtmltopdf_phase_description
        [DllImport(DLLNAMEx86, EntryPoint = "wkhtmltopdf_phase_description", CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr wkhtmltopdf_phase_description_x86(IntPtr converter, int phase);

        [DllImport(DLLNAMEx64, EntryPoint = "wkhtmltopdf_phase_description", CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr wkhtmltopdf_phase_description_x64(IntPtr converter, int phase);
        #endregion

        #region wkhtmltopdf_progress_string
        [DllImport(DLLNAMEx86, EntryPoint = "wkhtmltopdf_progress_string", CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr wkhtmltopdf_progress_string_x86(IntPtr converter);

        [DllImport(DLLNAMEx64, EntryPoint = "wkhtmltopdf_progress_string", CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr wkhtmltopdf_progress_string_x64(IntPtr converter);
        #endregion

        #region wkhtmltopdf_http_error_code
        [DllImport(DLLNAMEx86, EntryPoint = "wkhtmltopdf_http_error_code", CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern int wkhtmltopdf_http_error_code_x86(IntPtr converter);

        [DllImport(DLLNAMEx64, EntryPoint = "wkhtmltopdf_http_error_code", CharSet = CHARSET, CallingConvention = CallingConvention.Cdecl)]
        public static extern int wkhtmltopdf_http_error_code_x64(IntPtr converter);
        #endregion

        #endregion

        #region Image to  PDF bindings


        #endregion
    }
}
