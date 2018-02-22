using System;
using System.Diagnostics;

namespace NPP.Utils
{
    internal class DebugWriter : ILogWriter
    {
        public void Write(string msg)
        {
            Debug.WriteLine(DateTime.Now.ToString() + " : " + msg);
        }
    }
}