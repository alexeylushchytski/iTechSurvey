using System;
using NLog;
using ILogger = iTechArt.Common.Helpers.Interfaces.ILogger;

namespace iTechArt.Common.Logger.NLogger
{
    public class NLogger : ILogger
    {
        private readonly NLog.ILogger _logger = LogManager.GetCurrentClassLogger();


        public void Log(string objectToLog)
        {
            _logger.Log(LogLevel.Info, objectToLog);
        }


        public void LogError(Exception objectToLog)
        {
            _logger.Log(LogLevel.Error, objectToLog);
        }


        public void LogWarning(string objectToLog)
        {
            _logger.Log(LogLevel.Warn, objectToLog);
        }
    }
}