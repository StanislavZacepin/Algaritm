using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algaritm_Dz.Dz.dz2
{
//    2. Реализовать функцию возведения числа a в степень b: Зацепин Станислав
//a.без рекурсии;
//    b.рекурсивно;
   public static class Dz2_2
    {
      static  double Число { get; set; }
       static int Степень { get; set; }
        public static void Start()
        {
            Console.WriteLine("Введите число");
            Console.ForegroundColor = ConsoleColor.Green;
            Число = double.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Ведите Степень");
            Console.ForegroundColor = ConsoleColor.Green;
            Степень = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;

            возведения_числа_рекурсивно(Число, Степень);
           
        }
        public static  double возведения_числа_рекурсивно(double a, int b)
        {
            if (b == 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Число {Число} в степени {Степень} = {a}");
                Console.ForegroundColor = ConsoleColor.White;
                return 1;
            }

            return возведения_числа_рекурсивно(Число*a, b - 1);
        }

        public static double возведения_числа(double a, int b)
        {

            return a;
           
        }
    }
}
