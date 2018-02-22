using System.Configuration;

namespace NPP.Utils
{
    public class LogWriterFactory
    {
        public static ILogWriter GetLoggerWriter()
        {
            var writer = ConfigurationManager.AppSettings["LoggerSetting"];
            switch (writer)
            {
                case "Debug":
                    return new DebugWriter();
                default:
                    return new FileWriter();
            }
        }
    }
}