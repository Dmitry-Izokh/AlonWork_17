using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlonWork_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Сheck<int> check1 = new Сheck<int>();
            check1.Input();
            Console.WriteLine(check1.GetInfo());

            Сheck<string> check2 = new Сheck<string>();
            check2.Input();
            Console.WriteLine(check2.GetInfo());

            Console.ReadKey();
        }
    }
}
