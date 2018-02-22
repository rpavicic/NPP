using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPP.Utils
{
    public class Logger
    {
        #region Singleton

        private static Logger _instance;

        public static Logger Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Logger();
                }
                return _instance;
            }
        }

        private Logger()
        {

        }
        #endregion

        public void Info(string msg)
        {
            var msgToLog = "Information: " + msg;
            LogWriterFactory.GetLoggerWriter().Write(msgToLog);
        }
        public void Warning(string msg)
        {
            var msgToLog = "Warning: " + msg;
            LogWriterFactory.GetLoggerWriter().Write(msgToLog);
        }

        public void Error(string msg)
        {
            var msgToLog = "Error: " + msg;
            LogWriterFactory.GetLoggerWriter().Write(msgToLog);
        }
    }
}
