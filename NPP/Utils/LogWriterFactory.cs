using System.Configuration;

namespace NPP.Utils
{
    public class LogWriterFactory
    {
        public static ILogWriter GetLoggerWriter()
        {
            var value = ConfigurationManager.AppSettings["LoggerSetting"];
            switch (value)
            {
                case "Debug":
                    return new DebugWriter();
                default:
                    return new FileWriter();
            }
        }
    }
}