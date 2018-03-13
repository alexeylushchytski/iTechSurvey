using NLog;
using ILogger = iTechArt.Common.Helpers.Interfaces.ILogger;

namespace iTechArt.Common.Logger.NLogger
{
    public class NLogger : ILogger
    {
        private readonly NLog.ILogger _logger = LogManager.GetCurrentClassLogger();


        public void Log(object objectToLog)
        {
            _logger.Log(LogLevel.Info, objectToLog);
        }


        public void LogError(object objectToLog)
        {
            _logger.Log(LogLevel.Error, objectToLog);
        }


        public void LogWarning(object objectToLog)
        {
            _logger.Log(LogLevel.Warn, objectToLog);
        }
    }
}