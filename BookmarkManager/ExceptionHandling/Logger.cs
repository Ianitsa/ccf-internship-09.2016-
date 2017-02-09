using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Logger
    {
        internal static void Log(Exception ex)
        {
            Console.Write("Log(Exception ex): " + ex.Message);
        }
    }
}
