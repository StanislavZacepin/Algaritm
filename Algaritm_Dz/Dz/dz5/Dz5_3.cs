using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algaritm_Dz.Dz.dz5
{
   static public class Dz5_3
    {
        static public void Start()
        {
            Stack<char> stack = new Stack<char>();
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();

            for (int i = 0; i < str.Length; i++)
                if (str[i] == '(')
                    stack.Push('(');
                else if (str[i] == ')' & stack.Count > 0)
                    stack.Pop();

            Console.WriteLine((stack.Count == 0) ? "Выражение верное." : "Выражение не верное!");
            Console.ReadKey();
        }
    }
}
