using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algaritm_Dz.Dz.dz8
{
  public static  class Dz8_1
    {// сортировки подсчетом
        static int[] BasicCountingSort(int[] array, int k)
        {
            var count = new int[k + 1];
            for (var i = 0; i < array.Length; i++)
            {
                count[array[i]]++;
            }

            var index = 0;
            for (var i = 0; i < count.Length; i++)
            {
                for (var j = 0; j < count[i]; j++)
                {
                    array[index] = i;
                    index++;
                }
            }

            return array;
        }

        static int[] GetRandomArray(int arraySize, int minValue, int maxValue)
        {
            var random = new Random();
            var randomArray = new int[arraySize];
            for (var i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = random.Next(minValue, maxValue);
            }

            return randomArray;
        }

      public  static void Start()
        {
            var arr = GetRandomArray(10, 0, 9);
            Console.WriteLine("Входные данные: {0}", string.Join(", ", arr));
            Console.WriteLine("Отсортированный массив: {0}", string.Join(", ", BasicCountingSort(arr, 9)));
            Console.ReadLine();
        }
    }
}

