using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace PrinterError
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, please enter your string:");
            Console.WriteLine("Result is: {0}", PrinterError(Console.ReadLine()));
            Console.ReadKey();
        }
        public static string PrinterError(String s)
        {
            string temp = "";
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            //Var 1:
            //temp = s.Where(c => c > 'm').Count() + "/" + s.Length;

            //Var 2:
            int i = 0;
            bool flag = false;
            char[] colorSign = new char[] {'a','b','c','d','e','f','g','h','i','j','k','l','m'};
            foreach(char c in s.ToCharArray())
            {
                foreach(char check in colorSign)
                {
                    if (c == check)
                    {
                        flag = false;
                        break;
                    }
                    else
                    {
                        flag = true;
                    }
                }
                if (flag) i++;
                flag = false;
            }
            temp = i.ToString() + "/" + s.Length;
            System.Threading.Thread.Sleep(10000);
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",ts.Hours, ts.Minutes, ts.Seconds,ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
            return temp;
        }
    }
}
