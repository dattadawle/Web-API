using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    internal class FileLogger : ILogger
    {
        

        public void Log(string message)
        {
            Console.WriteLine("message logged to File");
            File.AppendAllText(@"Logs/errors.txt", $"{message} \n");
        }
    }
}
