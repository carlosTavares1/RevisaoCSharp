using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TutorialCSAdvanced
{
    class Program
    {
        static void FazerAlgo()
        {
            Thread.Sleep(5000);
            Console.WriteLine("Terminei a tarefa!");
        }

        static void Main(string[] args)
        {
            int sum = 0;
            bool completed = false;
            Thread t = new Thread(new ThreadStart(() =>
            {
                while (!completed)
                {
                    sum += 1;
                }
            }));

            t.Start();
            Thread.Sleep(8000);
            completed = true;
            Console.WriteLine("Sum is: {0}", sum);

            Console.ReadKey();
        }
    }
}
