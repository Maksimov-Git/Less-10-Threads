using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using System.Runtime.Remoting.Contexts;

namespace Less_10__CriticalSection
{
    class MyClass
    {
        object block = new object();

        public void Method()
        {
            int hash = Thread.CurrentThread.GetHashCode();

             lock (block) // Закомментировать lock.
         //   Monitor.Enter(block);
           {
                for (int counter = 0; counter < 10; counter++)
                {
                    Console.WriteLine("Поток # {0}: шаг {1}", hash, counter);
                    Thread.Sleep(100);
                }
                Console.WriteLine(new string('-', 20));
            }
           // Monitor.Exit(block);
        }

    }

    [Synchronization]
    class MyClass1:ContextBoundObject
    {
       
        
        public void Method()
        {
            int hash = Thread.CurrentThread.GetHashCode();
          
            {
                for (int counter = 0; counter < 10; counter++)
                {
                    Console.WriteLine("Поток # {0}: шаг {1}", hash, counter);
                    Thread.Sleep(100);
                }
                Console.WriteLine(new string('-', 20));
            }
            
        }

    }



    class Program
        {
            static void Main()
            {
                Console.SetWindowSize(80, 40);

                MyClass instance = new MyClass();

                for (int i = 0; i < 3; i++)
                {
                    new Thread(instance.Method).Start();
                }

                Thread.Sleep(500);

                // Delay.
                Console.ReadKey();
            }
        }
    
}
