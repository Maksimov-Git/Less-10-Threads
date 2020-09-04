using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Less_10_threads_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            // анонимные методы 
            Thread th = new Thread(delegate () { Console.WriteLine("поток 1 {0} ", ++counter); });
            th.Start();

            Thread.Sleep(1);

            Console.WriteLine("основной поток {0} ", counter);
            // лямба оператор 
            Thread th1 = new Thread((object arg) => { Console.WriteLine("поток 2 {0}", (int)arg); });
            th1.Start(counter);



            Console.ReadKey();
        }
    }
}
