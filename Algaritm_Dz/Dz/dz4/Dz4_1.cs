using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algaritm_Dz.Dz.dz4
{
//  Зацепин С.С.  1. * Количество маршрутов с препятствиями.Реализовать чтение массива с препятствием и нахождение количество маршрутов.
//Например, карта:
//3 3
//1 1 1
//0 1 0
//0 1 0
   public static class Dz4_1
    {
        public static void Start()
        {
            CreatsMaps(8, 8);
        }
         static int CreatsMaps(int n , int k)
        {
            int [,] Maps = new int  [n + 1, n + 1];
            for (int i = 0; i <= n; i++)
            {
                Maps[i, 0] = 1;
                Maps[i, i] = 1;
                for (int j = 1; j < i; j++)
                {
                    Maps[i, j] = Maps[i - 1, j - 1] + Maps[i - 1, j];
                }
                
            }
            printer(Maps,n,k);
            return Maps[n,k];
        }
        static void printer(int[,] mass, int n,int m)
        {

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(String.Format("{0,3}", mass[i, j]));
                Console.WriteLine();
            }
        }
    }
}
