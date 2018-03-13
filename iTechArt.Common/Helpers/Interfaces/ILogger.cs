using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTechArt.Common.Helpers.Interfaces
{
    public interface ILogger
    {
        void Log(object objectToLog);

        void LogWarning(object objectToLog);

        void LogError(object objectToLog);
    }
}
