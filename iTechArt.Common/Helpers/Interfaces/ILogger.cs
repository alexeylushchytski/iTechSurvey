using System;

namespace iTechArt.Common.Helpers.Interfaces
{
    public interface ILogger
    {
        void Log(string objectToLog);


        void LogWarning(string objectToLog);


        void LogError(Exception objectToLog);
    }
}