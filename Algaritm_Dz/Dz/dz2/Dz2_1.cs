using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algaritm_Dz.Dz.dz2
{
   public static class Dz2_1
    {
        public static void Start()
        {
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число которое хотите перевести в двоичную систему");
            С_десятичной_Перевод_в_Двоичную(i,"");
        }
        public static int С_десятичной_Перевод_в_Двоичную(int i , string d)
        {
            var b = i % 2;
            if (i <= 1)
            {
                if (b == 1) d += '1';
                else if (b == 0) d += '0';
               d = new string(d.Reverse().ToArray());
                Console.WriteLine($"В двоичной системе {d}");
                return 0;
            }
            if (b == 1) d += '1';
            else if (b == 0) d += '0';
            return С_десятичной_Перевод_в_Двоичную(i / 2, d);
        }
    }
}
