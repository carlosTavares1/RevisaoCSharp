using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Task[] tasks = new Task[2]
            {
                Task.Factory.StartNew(() => {
                    Console.WriteLine("Tarefa 1");
                }),
                Task.Factory.StartNew(() => {
                    Console.WriteLine("Tarefa 2");
                })
            };

            Task.WaitAll(tasks);

            Console.ReadKey();
        }
    }
}
