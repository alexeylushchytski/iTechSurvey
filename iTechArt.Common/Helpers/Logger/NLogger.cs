using System;
using System.ComponentModel;
using NLog;
namespace iTechArt.Common.Helpers.Logger
{
    public class NLogger : ILoggerBase
    {
        public NLog.Logger Logger;

        public NLogger()
        {
            Logger = LogManager.GetCurrentClassLogger();
        }

        public string Name => ((ILoggerBase)Logger).Name;

        public LogFactory Factory => ((ILoggerBase)Logger).Factory;

        public event EventHandler<EventArgs> LoggerReconfigured
        {
            add
            {
                ((ILoggerBase)Logger).LoggerReconfigured += value;
            }

            remove
            {
                ((ILoggerBase)Logger).LoggerReconfigured -= value;
            }
        }

        public bool IsEnabled(LogLevel level)
        {
            return ((ILoggerBase)Logger).IsEnabled(level);
        }

        public void Log(LogEventInfo logEvent)
        {
            ((ILoggerBase)Logger).Log(logEvent);
        }

        public void Log(Type wrapperType, LogEventInfo logEvent)
        {
            ((ILoggerBase)Logger).Log(wrapperType, logEvent);
        }

        public void Log<T>(LogLevel level, T value)
        {
            ((ILoggerBase)Logger).Log(level, value);
        }

        public void Log<T>(LogLevel level, IFormatProvider formatProvider, T value)
        {
            ((ILoggerBase)Logger).Log(level, formatProvider, value);
        }

        public void Log(LogLevel level, LogMessageGenerator messageFunc)
        {
            ((ILoggerBase)Logger).Log(level, messageFunc);
        }

        public void Log(LogLevel level, Exception exception, [Localizable(false)] string message, params object[] args)
        {
            ((ILoggerBase)Logger).Log(level, exception, message, args);
        }

        public void Log(LogLevel level, Exception exception, IFormatProvider formatProvider, [Localizable(false)] string message, params object[] args)
        {
            ((ILoggerBase)Logger).Log(level, exception, formatProvider, message, args);
        }

        public void Log(LogLevel level, IFormatProvider formatProvider, [Localizable(false)] string message, params object[] args)
        {
            ((ILoggerBase)Logger).Log(level, formatProvider, message, args);
        }

        public void Log(LogLevel level, [Localizable(false)] string message)
        {
            ((ILoggerBase)Logger).Log(level, message);
        }

        public void Log(LogLevel level, [Localizable(false)] string message, params object[] args)
        {
            ((ILoggerBase)Logger).Log(level, message, args);
        }

        public void Log(LogLevel level, [Localizable(false)] string message, Exception exception)
        {
            ((ILoggerBase)Logger).Log(level, message, exception);
        }

        public void Log<TArgument>(LogLevel level, IFormatProvider formatProvider, [Localizable(false)] string message, TArgument argument)
        {
            ((ILoggerBase)Logger).Log(level, formatProvider, message, argument);
        }

        public void Log<TArgument>(LogLevel level, [Localizable(false)] string message, TArgument argument)
        {
            ((ILoggerBase)Logger).Log(level, message, argument);
        }

        public void Log<TArgument1, TArgument2>(LogLevel level, IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2)
        {
            ((ILoggerBase)Logger).Log(level, formatProvider, message, argument1, argument2);
        }

        public void Log<TArgument1, TArgument2>(LogLevel level, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2)
        {
            ((ILoggerBase)Logger).Log(level, message, argument1, argument2);
        }

        public void Log<TArgument1, TArgument2, TArgument3>(LogLevel level, IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
        {
            ((ILoggerBase)Logger).Log(level, formatProvider, message, argument1, argument2, argument3);
        }

        public void Log<TArgument1, TArgument2, TArgument3>(LogLevel level, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3)
        {
            ((ILoggerBase)Logger).Log(level, message, argument1, argument2, argument3);
        }

        public void Log(LogLevel level, object value)
        {
            ((ILoggerBase)Logger).Log(level, value);
        }

        public void Log(LogLevel level, IFormatProvider formatProvider, object value)
        {
            ((ILoggerBase)Logger).Log(level, formatProvider, value);
        }

        public void Log(LogLevel level, string message, object arg1, object arg2)
        {
            ((ILoggerBase)Logger).Log(level, message, arg1, arg2);
        }

        public void Log(LogLevel level, string message, object arg1, object arg2, object arg3)
        {
            ((ILoggerBase)Logger).Log(level, message, arg1, arg2, arg3);
        }

        public void Log(LogLevel level, IFormatProvider formatProvider, string message, bool argument)
        {
            ((ILoggerBase)Logger).Log(level, formatProvider, message, argument);
        }

        public void Log(LogLevel level, string message, bool argument)
        {
            ((ILoggerBase)Logger).Log(level, message, argument);
        }

        public void Log(LogLevel level, IFormatProvider formatProvider, string message, char argument)
        {
            ((ILoggerBase)Logger).Log(level, formatProvider, message, argument);
        }

        public void Log(LogLevel level, string message, char argument)
        {
            ((ILoggerBase)Logger).Log(level, message, argument);
        }

        public void Log(LogLevel level, IFormatProvider formatProvider, string message, byte argument)
        {
            ((ILoggerBase)Logger).Log(level, formatProvider, message, argument);
        }

        public void Log(LogLevel level, string message, byte argument)
        {
            ((ILoggerBase)Logger).Log(level, message, argument);
        }

        public void Log(LogLevel level, IFormatProvider formatProvider, string message, string argument)
        {
            ((ILoggerBase)Logger).Log(level, formatProvider, message, argument);
        }

        public void Log(LogLevel level, string message, string argument)
        {
            ((ILoggerBase)Logger).Log(level, message, argument);
        }

        public void Log(LogLevel level, IFormatProvider formatProvider, string message, int argument)
        {
            ((ILoggerBase)Logger).Log(level, formatProvider, message, argument);
        }

        public void Log(LogLevel level, string message, int argument)
        {
            ((ILoggerBase)Logger).Log(level, message, argument);
        }

        public void Log(LogLevel level, IFormatProvider formatProvider, string message, long argument)
        {
            ((ILoggerBase)Logger).Log(level, formatProvider, message, argument);
        }

        public void Log(LogLevel level, string message, long argument)
        {
            ((ILoggerBase)Logger).Log(level, message, argument);
        }

        public void Log(LogLevel level, IFormatProvider formatProvider, string message, float argument)
        {
            ((ILoggerBase)Logger).Log(level, formatProvider, message, argument);
        }

        public void Log(LogLevel level, string message, float argument)
        {
            ((ILoggerBase)Logger).Log(level, message, argument);
        }

        public void Log(LogLevel level, IFormatProvider formatProvider, string message, double argument)
        {
            ((ILoggerBase)Logger).Log(level, formatProvider, message, argument);
        }

        public void Log(LogLevel level, string message, double argument)
        {
            ((ILoggerBase)Logger).Log(level, message, argument);
        }

        public void Log(LogLevel level, IFormatProvider formatProvider, string message, decimal argument)
        {
            ((ILoggerBase)Logger).Log(level, formatProvider, message, argument);
        }

        public void Log(LogLevel level, string message, decimal argument)
        {
            ((ILoggerBase)Logger).Log(level, message, argument);
        }

        public void Log(LogLevel level, IFormatProvider formatProvider, string message, object argument)
        {
            ((ILoggerBase)Logger).Log(level, formatProvider, message, argument);
        }

        public void Log(LogLevel level, string message, object argument)
        {
            ((ILoggerBase)Logger).Log(level, message, argument);
        }

        public void Log(LogLevel level, IFormatProvider formatProvider, string message, sbyte argument)
        {
            ((ILoggerBase)Logger).Log(level, formatProvider, message, argument);
        }

        public void Log(LogLevel level, string message, sbyte argument)
        {
            ((ILoggerBase)Logger).Log(level, message, argument);
        }

        public void Log(LogLevel level, IFormatProvider formatProvider, string message, uint argument)
        {
            ((ILoggerBase)Logger).Log(level, formatProvider, message, argument);
        }

        public void Log(LogLevel level, string message, uint argument)
        {
            ((ILoggerBase)Logger).Log(level, message, argument);
        }

        public void Log(LogLevel level, IFormatProvider formatProvider, string message, ulong argument)
        {
            ((ILoggerBase)Logger).Log(level, formatProvider, message, argument);
        }

        public void Log(LogLevel level, string message, ulong argument)
        {
            ((ILoggerBase)Logger).Log(level, message, argument);
        }

        public void LogException(LogLevel level, [Localizable(false)] string message, Exception exception)
        {
            ((ILoggerBase)Logger).LogException(level, message, exception);
        }
    }
}