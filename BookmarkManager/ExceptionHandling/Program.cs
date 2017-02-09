using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
                Console.Write(FormatWithLineNumbers(LoadFile("Test.txt")));
                Console.WriteLine("Regular execution");
                Console.Read();
            }
            catch (Exception ex)
            {
                Logger.Log(ex);
                Console.WriteLine("In error handling");
                Console.Read();
                //throw;
            }
            
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            throw new NotImplementedException();
        }

        private static string FormatWithLineNumbers(string p)
        {
            //throw new NotImplementedException();
            TcpClient client = new TcpClient();
            //client.BeginConnect(null, null, requestCallback, null);
            return null;
        }

        private static void requestCallback(IAsyncResult ar)
        {
            
        }

        private static string LoadFile(string filePath)
        {
            string result = null;
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                throw;
            }
            return result;
            
        }
    }
}
