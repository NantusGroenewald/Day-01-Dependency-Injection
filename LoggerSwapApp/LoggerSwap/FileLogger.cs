using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerSwap
{
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            string solutionDirectory = Directory.GetParent(Environment.CurrentDirectory)!.Parent!.Parent!.FullName;
            string filePath = Path.Combine(solutionDirectory, "logs.txt");

            using (StreamWriter writer = new StreamWriter(filePath, append: true))
            {
                writer.WriteLine($"{DateTime.UtcNow}: {message}");
            }
        }
    }
}
