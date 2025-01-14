using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class Demo
    {
        public void getName(string msg)
        {
            Console.WriteLine(Directory.GetCurrentDirectory());

            File.AppendAllText(@"Logs/error.txt", $"Message: {msg}\n");
        }
    }
}
