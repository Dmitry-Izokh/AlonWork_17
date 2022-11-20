using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlonWork_17
{
    class Сheck <T>
    {
        public T Num { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }

        public string GetInfo()
        {
            return $"{Num} {Balance} {Name}";
        }

        public void Input()
        {
            Console.WriteLine("Введите номер");
            string stringNum = Console.ReadLine();
            Num = (T)Convert.ChangeType(stringNum, typeof(T));

            Console.WriteLine("Введите баланс");
            Balance = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите Имя");
            Name = Console.ReadLine();
        }
    }
}
