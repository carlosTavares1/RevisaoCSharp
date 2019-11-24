using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS
{
    class Program
    {
        //async, await e Task

        static void Main(string[] args)
        {
            Console.WriteLine(Task.Run(() => GetMessage("Pedro")).Result);
            Console.ReadKey();
        }

        static string GetMessage(string nome)
        {
            return "Hello " + nome;
        }
    }
}
