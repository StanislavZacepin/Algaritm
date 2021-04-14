using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algaritm_Dz.Dz.dz1
{
    //2. Найти максимальное из четырех чисел. Массивы не использовать.
    public static class Dz1_2
    {
        static int number1 { get; set; }
        static int number2 { get; set; }
        static int number3 { get; set; }
        static int number4 { get; set; }
        static int numberMax { get; set; }

        static int count = 0;
        public static void Start()
        {
           print();
           number1 = int.Parse(Console.ReadLine());

            print();
            number2 = int.Parse(Console.ReadLine());

            print();
            number3 = int.Parse(Console.ReadLine());

            print();
            number4 = int.Parse(Console.ReadLine());

            startDz();
        }
       
        public static void startDz()
        {
            numberMax = Math.Max(Math.Max(number1, number2), Math.Max(number3, number4));


            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Максимальное число {0}",numberMax);

            Console.ForegroundColor = ConsoleColor.White;
        }
       private static void print()
        {
            count++;
            Console.WriteLine("Введите  Число{0}", count);
        }
    }
}
