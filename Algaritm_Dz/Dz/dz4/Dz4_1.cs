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
            int rn;
            Random rnd = new Random();
            int [,] Maps = new int  [n+1, k+1];
            for (int j = 0; j <= k; j++)
            {
                rn = rnd.Next(0, 3);
                if (rn == 0) Maps[0, j] = 0; 
                else  Maps[0, j] = 1;
               
            }
            printer(Maps, n, k);
            for (int i = 1; i < n; i++)
            {
                rn = rnd.Next(0, 3);
                if (rn == 0) Maps[i,0] = 0;
                else Maps[i, 0] = 1;
                for (int j = 1; j < k; j++)
                {
                    Maps[i, j] = Maps[i, j - 1] + Maps[i - 1, j];
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
                {
                    Console.Write(String.Format(" {0,3} ", mass[i, j]));
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------------------------");
        }
    }
}
