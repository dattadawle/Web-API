﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    internal class DatabaseLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Message logged to database");
        }
    }
}
