namespace iTechArt.Common.Helpers.Interfaces
{
    public interface ILogger
    {
        void Log(object objectToLog);

        void LogWarning(object objectToLog);

        void LogError(object objectToLog);
    }
}