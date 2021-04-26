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
using Algaritm_Dz.Dz.dz5;
using Algaritm_Dz.Dz.dz6;
using Algaritm_Dz.Dz.dz7;

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
                case 42:
                    clearConsole();
                    Dz4_2.Start();//42. Решить задачу о нахождении длины максимальной последовательности с помощью матрицы.
                    break;
                case 51:
                    clearConsole();
                    Dz5_1.Start();//51. Реализовать перевод из десятичной в двоичную систему счисления с использованием стека.
                    break;
                case 52:
                    clearConsole();
                    Dz5_2.Start();//52. Добавить в программу «реализация стека на основе односвязного списка» проверку на выделение памяти. Если память не выделяется, то выводится соответствующее сообщение. Постарайтесь создать ситуацию, когда память не будет выделяться (добавлением большого количества данных).
                    break;
                case 53:
                    clearConsole();
                    Dz5_3.Start();//53. Написать программу, которая определяет, является ли введенная скобочная последовательность правильной. Примеры правильных скобочных выражений: (), ([])(), {}(), ([{}]), неправильных — )(, ())({), (, ])}), ([(]) для скобок [,(,{.
                //Например: (2 + (2 * 2)) или[2 /{ 5 * (4 + 7)}]
                    break;
                case 61:
                    clearConsole();
                    Dz6_1.Start();//61. Реализовать простейшую хеш-функцию. На вход функции подается строка, на выходе сумма кодов символов.
                    break;
                case 62:
                    clearConsole();
                    Dz6_2.Start(); //2. Переписать программу, реализующую двоичное дерево поиска.
                    break;
                case 71:
                    clearConsole();
                    Dz7_1.Start();//71. Написать функции, которые считывают матрицу смежности из файла и выводят ее на экран.
                    break;
                case 72:
                    clearConsole();
                    Dz7_2.Start();//72. Написать рекурсивную функцию обхода графа в глубину.
                    break;
                default:
                    break;
            }
        }
        
    }
}
