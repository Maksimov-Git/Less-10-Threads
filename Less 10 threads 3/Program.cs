using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less_10_threads_3
{
    class Program
    {
        static void Second(object arg)
        {
            while (true)
            {
                Console.WriteLine(arg.ToString());
                System.Threading.Thread.Sleep(1000);
            }
        }

        static void Main(string[] args)
        {
            System.Threading.ParameterizedThreadStart del = new System.Threading.ParameterizedThreadStart(Second);


            System.Threading.Thread th = new System.Threading.Thread(del);
            th.Start("Привет! ");
            Console.ReadKey();

        }
    }
}
