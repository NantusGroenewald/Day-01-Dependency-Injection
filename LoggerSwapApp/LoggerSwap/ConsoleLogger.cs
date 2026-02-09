using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerSwap
{
    public class ConsoleLogger : ILogger
    {
        private readonly Guid msgGuid;

        public ConsoleLogger()
        {
             msgGuid = Guid.NewGuid(); 
        }

        public void Log(string message)
        {
            Console.WriteLine($"{msgGuid} : {message}");
        }
    }
}
