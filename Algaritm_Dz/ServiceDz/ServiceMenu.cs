using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algaritm_Dz.Dz.dz1;
using System.IO;
using Algaritm_Dz.Dz.dz2;
using Algaritm_Dz.Dz.dz3;
using Algaritm_Dz.Dz.dz4;

namespace Algaritm_Dz.ServiceDz
{
    public class ServiceMenu
    {
        private int i { get; set; }


        public ServiceMenu(int i)
        {
            this.i = i;
        }

        void clearConsole()
        {
            Console.Clear();
        }
        public void StartMenu()
        {
            switch (i)
            {
                case 1:
                    clearConsole();
                        Dz1_1.Dz1(); //Рассчитать и вывести индекс массы тела по формуле I = m / (h * h); где m-масса тела в килограммах, h - рост в метрах
                    break;
                case 2:
                    clearConsole();
                    Dz1_2.Start(); //2. Найти максимальное из четырех чисел. Массивы не использовать.
                    break;
                case 12:
                    clearConsole();
                    Dz1_12.Start(); //12.Написать функцию нахождения максимального из трех чисел.
                    break;
                case 21:
                    clearConsole();
                    Dz2_1.Start(); //21. Реализовать функцию перевода из десятичной системы в двоичную, используя рекурсию.
                    break;
                case 22:
                    clearConsole();
                    Dz2_2.Start();//22. Реализовать функцию возведения числа a в степень b:
                    break;
                case 31:
                    clearConsole();
                    Dz3_1.Start();//31. Попробовать оптимизировать пузырьковую сортировку. Сравнить количество операций сравнения оптимизированной и не оптимизированной программы. Написать функции сортировки, которые возвращают количество операций.
                    break;
                case 41:
                    clearConsole(); //  Зацепин С.С.  1. * Количество маршрутов с препятствиями.Реализовать чтение массива с препятствием и нахождение количество маршрутов.
                                    //Например, карта:
                                    //3 3
                                    //1 1 1
                                    //0 1 0
                                    //0 1 0
                    Dz4_1.Start(); 
                    break;
                default:
                    break;
            }
        }
        
    }
}
