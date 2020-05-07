using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Задание_2_к
{
    class Program
    {
        static void posled(float first, float dif, int n,ref float resln, ref float reslsum, int i = 1)
        {
            if (i == 1)
            {
                resln = first;
                reslsum = resln;
                posled(first, dif, n, ref resln, ref reslsum, i + 1);
            }
            else if (i <= n)
            {
                resln = resln + dif;
                reslsum += resln;
                posled(first, dif, n, ref resln, ref reslsum, i + 1);
            }
        }
        static void Main(string[] args)
        {
            float f, d, resln=0,reslsum=0;
            int n = 0;
            bool prov;
            do
            {
                Console.Write("Введите первый член арифметической прогрессии:");
                prov = float.TryParse(Console.ReadLine(), out f);
                if (!prov)
                    Console.WriteLine("Некорректный ввод");
            } while (!prov);
            do
            {
                Console.Write("Введите разность арифметической прогрессии:");
                prov = float.TryParse(Console.ReadLine(), out d);
                if (!prov)
                    Console.WriteLine("Некорректный ввод");
            } while (!prov);
            do
            {
                Console.Write("Введите порядковый номер члена арифметической прогрессии:");
                prov = int.TryParse(Console.ReadLine(), out n);
                if (n <= 0)
                {
                    Console.WriteLine("Некорректный ввод");
                    prov = false;
                }
            } while (!prov);
            posled(f,d,n, ref resln, ref reslsum);
            Console.WriteLine("Значение {0}-го члена последовательности = {1}", n, resln);
            Console.WriteLine("Сумма {0} первых членов прогрессии = {1}", n, reslsum);
            Console.ReadLine();
        }
    }
}
