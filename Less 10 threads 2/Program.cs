using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Less_10_threads_2
{
    class Program
    {
        static void WriteSecond()
        {
            // возвращает ссылку на экземпляр текущего потока 
            Thread thread = Thread.CurrentThread;
            thread.Name = "Вторичный";

            //  
      

            for (int i = 0; i < 100;i++ )
            {
                Console.WriteLine("                   Имя Потока {0}, id {1} - {2} ", thread.Name, thread.GetHashCode(),i);

                Thread.Sleep(1000);
            }

        }



        static void Main(string[] args)
        {
            // ссылка на экземпляр текущего потока 
            Thread primary = Thread.CurrentThread;
            primary.Name = "Первичный";

            // создаем вторичный поток 
            Thread secondary = new Thread(WriteSecond);
            secondary.Start();



            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Имя Потока {0}, id {1} - {2} ", primary.Name, primary.GetHashCode(),i);

                Thread.Sleep(1500);
            }

            // создание нового потока занимает какое то время, в этот момент 
            //выполнение основного потока программы не завершается




            //secondary.IsBackground = true;
           
        }
    }
}
