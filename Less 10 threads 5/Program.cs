using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;


namespace Less_10_threads_5
{
    class Program
    {
        static void Tick(object o)
        {
            Console.WriteLine("Tick");
        }

        static void Main(string[] args)
        {
            TimerCallback tim = new TimerCallback(Tick);
            Timer t = new Timer(Tick,null,3000,100);
            Console.ReadKey();
        }
    }
}
