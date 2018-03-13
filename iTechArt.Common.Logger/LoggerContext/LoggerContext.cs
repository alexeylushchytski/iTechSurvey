using NLog;
using ILogger = iTechArt.Common.Helpers.Interfaces.ILogger;

namespace iTechArt.Common.Logger.LoggerContext
{
    public static class LoggerContext
    {
        private static ILogger _current;


        private static readonly ILogger DefaultLogger = new NLogger.NLogger();


        public static ILogger Current
        {
            get => _current ?? (_current = DefaultLogger);
            set => _current = value;
        }
    }
}
