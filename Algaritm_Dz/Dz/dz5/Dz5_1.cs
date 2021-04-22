using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algaritm_Dz.Dz.dz5
{
   public static class Dz5_1
    {
       static Stack<int> Masiv = new Stack<int>(10);
        
        public static void Start()
        {
            
            Console.WriteLine("Введите число которое хотите перевести в двоичную систему");
            int i = int.Parse(Console.ReadLine());
            
            С_десятичной_Перевод_в_Двоичную(i);
        }
        public static int С_десятичной_Перевод_в_Двоичную(int i)
        {
            var b = i % 2;
            if (i <= 1)
            {
                if (b == 1) Masiv.Push(1);
                else if (b == 0) Masiv.Push(0);
                
                Console.WriteLine($"В двоичной системе ");
                printer(Masiv);
                return 0;
            }
            if (b == 1) Masiv.Push(1);
            else if (b == 0) Masiv.Push(0);
            return С_десятичной_Перевод_в_Двоичную(i / 2);
        }
        static void printer(Stack<int> asiv)
        {
            foreach (var item in Masiv)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
