using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algaritm_Dz.Dz.dz5
{
   static public class Dz5_3
    {
        static bool TestParenthesis(string source)
        {
            Stack<int> stack = new Stack<int>();
            foreach (char character in source)
            {
                int index = "([{)]}".IndexOf(character);
                if (index >= 3)
                {
                    if (stack.Count == 0 || stack.Pop() != index) return false;
                }
                else if (index >= 0) stack.Push(index + 3);
            }
            return stack.Count == 0;
        }
        static public void Start()
        {
            string goodSource = "{[]}[]()";
            Console.WriteLine(TestParenthesis(goodSource));
            string basSource = "{[]}[])";
            Console.WriteLine(TestParenthesis(basSource));
            Console.ReadKey();
        }
    }
    }

