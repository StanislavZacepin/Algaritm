using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algaritm_Dz.Dz.dz1
{
   public static class Dz1_12
    {//Зацепин Станислав Написать функцию, возвращающий Максимальное из трех чисел.
        static  int count = 0;
        static int maxsimum(int number1, int number2, int number3)
        {

            int Max = number1 > number2 ? number1 : number2;

            Max = Max > number3 ? Max : number3;
           
            return Max;
        }
      public  static void Start()

        {
            Console.ForegroundColor = ConsoleColor.Green;


            int Max;
            print();
            int number1 = Convert.ToInt32(Console.ReadLine());

            print();
            int number2 = Convert.ToInt32(Console.ReadLine());

            print();
            int number3 = Convert.ToInt32(Console.ReadLine());

            Max = maxsimum(number1, number2, number3);

            Console.WriteLine($"Максимальное число {Max}");

            Console.ForegroundColor = ConsoleColor.White;
          
        }
        private static void print()
        {
            count++;
            Console.WriteLine("Введите  Число{0}", count);
        }
    }
}

