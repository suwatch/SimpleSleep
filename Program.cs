using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SimpleSleep
{
    class Program
    {
        static int Main(string[] args)
        {
            try
            {
                foreach (string arg in args)
                {
                    int timeout = Int32.Parse(arg);
                    Thread.Sleep(timeout);
                    Console.WriteLine("Sleep(" + timeout + ")");
                }
                return 0;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex);
                return -1;
            }
        }
    }
}
