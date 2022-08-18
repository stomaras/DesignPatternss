using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullCheckDesignPattern
{
    public class ConsoleLog : ILog
    {
        public void Info(string message)
        {
            Console.WriteLine(message);
        }

        public void warn(string message)
        {
            Console.WriteLine("Warning !!! " + message);
        }
    }
}
