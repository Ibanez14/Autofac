using System;
using System.Collections.Generic;
using System.Text;

namespace DemoLibrary.Utilitites
{
    public class Logger : ILogger
    {
        public void LogData(string data)
        {
            Console.WriteLine(data);
        }
    }
}
