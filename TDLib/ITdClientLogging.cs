using System;

namespace TDLib
{
    public interface ITdClientLogging
    {
        int VerbosityLevel { set; }
        bool SetLogFilePath(string path);
        void SetLogMaxFileSize(long maxsize);
        void SetLogFatalErrorCallback(Action<string> callback);
    }
}
