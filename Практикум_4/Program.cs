using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1_к
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0,resl;
            bool prov;
            do
            {
                Console.Write("Введите порядковый номер члена последовательности:");
                prov = int.TryParse(Console.ReadLine(), out n);
                if (n <= 0)
                {
                    Console.WriteLine("Некорректный ввод");
                    prov = false;
                }
            } while (!prov);
            resl = posled(n);
            Console.WriteLine("Значение {0}-го члена последовательности = {1}", n, resl);
            Console.ReadLine();
        }
        static int posled(int n)
        {
            if (n == 1)
                return -10;
            if (n == 2)
                return 2;
            return (Math.Abs(posled(n - 2)) - 6 * posled(n - 1));
        }
    }
}
