using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// подключаем пространоство имен
using System.Threading;

namespace Less_10_threads_1
{
    class Program
    {// просто метод, выводящий в консоль 
        static void Writethread()
        {
            while (true)
            {
                Thread.Sleep(1);
                Console.WriteLine("           поток 2 ");
            
            }
        }
        
        static void Main(string[] args)
        {

            // Делегат  из System.Threading
            ThreadStart writethread = new ThreadStart(Writethread);

            // содаем экземпляр класс  thread  и в конструкторе конфигурируем его делегатом для асинхронного выполнения
            Thread th =  new Thread(writethread);
            th.Start();

           // синхронный вызов  Writethread();
            

            while (true)
            {
                Thread.Sleep(10);
                Console.WriteLine("поток 1");
            }

        }
    }
}
