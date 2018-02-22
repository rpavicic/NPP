using System;
using System.IO;

namespace NPP.Utils
{
    internal class FileWriter : ILogWriter
    {
        public void Write(string msg)
        {
            using (StreamWriter sw = new StreamWriter("../../Files/logs.txt", true))
            {
                sw.WriteLine(DateTime.Now.ToString() + " : " + msg);
            }
        }
    }
}