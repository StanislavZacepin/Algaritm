using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algaritm_Dz.Dz.dz3
{
    //Зацепин С.С
    //1. Попробовать оптимизировать пузырьковую сортировку. Сравнить количество операций сравнения оптимизированной и не оптимизированной программы. Написать функции сортировки, которые возвращают количество операций.
     public static class Dz3_1
    {
        static int countSwap = 0;// счетчик свапв

        static int cointSravnenia = 0; // счетчик сравнения 
         static void printer(int [] mass)
        {
        
            foreach (var item in mass)
            {
                Console.Write(item+"  ");
            }

            Console.WriteLine("____________");
        }

         static void swap(ref int one, ref int two)
        {
            int swap = one;
            one = two;
            two = swap;
            countSwap++;

        }

        static void createMassiv(ref int [] massiv)
        {
            
            Random rnd = new Random();

            for (int i = 0; i < massiv.Length; i++)
            {
               massiv[i] = rnd.Next(0, 101); 
            }
           
        }

        static void Sortirovka(ref int [] massiv)
        {
            for (int i = 0; i < massiv.Length; i++)
            {
                bool flag = false;

                for (int j = 0; j < massiv.Length-1; j++)
                {
                    cointSravnenia++;
                    if (massiv[j] > massiv[j + 1])
                    {
                        swap(ref massiv[j], ref massiv[j + 1]);

                        flag = true;
                    }
                }

                printer(massiv);
                if (flag == false) break;
            }
            Console.WriteLine("сравнивалось={0} Менялось местами={1}", cointSravnenia , countSwap);
        }
        public static void Start()
        {
            int[] massiv;
            Console.WriteLine("ведите размер масива");
            int size = int.Parse(Console.ReadLine());

            massiv = new int[size];

            createMassiv(ref massiv);

            Console.WriteLine("масив до сортировки");

            printer(massiv);

            Console.WriteLine("масив после сортировки");

            Sortirovka(ref massiv);

        }
    }
}
