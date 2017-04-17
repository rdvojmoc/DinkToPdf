using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DinkToPdf.Contracts
{
    public interface ITools : IDisposable
    {
        /// <summary>
        /// Load library and initialize wkhtmltopdf 
        /// </summary>
        void Load();

        /// <summary>
        /// Is set to true if library is loaded and wkhtmltopdf is initialized successfully
        /// </summary>
        bool IsLoaded { get; }

        bool ExtendedQt();

        string GetLibraryVersion();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IntPtr CreateGlobalSettings();

        int SetGlobalSetting(IntPtr settings, string name, string value);

        string GetGlobalSetting(IntPtr settings, string name);

        void DestroyGlobalSetting(IntPtr settings);

        IntPtr CreateObjectSettings();

        int SetObjectSetting(IntPtr settings, string name, string value);

        string GetObjectSetting(IntPtr settings, string name);

        void DestroyObjectSetting(IntPtr settings);

        IntPtr CreateConverter(IntPtr globalSettings);

        void AddObject(IntPtr converter, IntPtr objectSettings, byte[] data);

        void AddObject(IntPtr converter, IntPtr objectSettings, string data);

        bool DoConversion(IntPtr converter);

        void DestroyConverter(IntPtr converter);

        byte[] GetConversionResult(IntPtr converter);

        int SetPhaseChangedCallback(IntPtr converter, VoidCallback callback);

        int SetProgressChangedCallback(IntPtr converter, VoidCallback callback);

        int SetFinishedCallback(IntPtr converter, IntCallback callback);

        int SetWarningCallback(IntPtr converter, StringCallback callback);

        int SetErrorCallback(IntPtr converter, StringCallback callback);

        int GetPhaseCount(IntPtr converter);

        int GetCurrentPhase(IntPtr converter);

        string GetPhaseDescription(IntPtr converter, int phase);

        string GetProgressString(IntPtr converter);
    }
}
