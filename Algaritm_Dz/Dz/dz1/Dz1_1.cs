using System;

namespace Algaritm_Dz.Dz.dz1
{
    // Рассчитать и вывести индекс массы тела по формуле I=m/(h* h); где m-масса тела в килограммах, h - рост в метрах. Зацепин С.С
    public static class Dz1_1
    {
        public static void Dz1()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Введите вес");

            Console.ForegroundColor = ConsoleColor.White;

            float weight = float.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Введите рост");


            Console.ForegroundColor = ConsoleColor.White;

            float height = float.Parse(Console.ReadLine());

            float index = formula(weight, height);

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"Индекс масы тела {index} ");

            Console.ForegroundColor = ConsoleColor.White;

        }
        static float formula(float m, float h)
        {
            float i = m / (h * h);
            return i;
        }
    }

}
