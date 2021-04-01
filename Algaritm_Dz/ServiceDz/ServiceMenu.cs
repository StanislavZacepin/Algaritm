using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algaritm_Dz.Dz.dz1;
using System.IO;

namespace Algaritm_Dz.ServiceDz
{
   public  class ServiceMenu
    {
        private int i { get; set; }

        
        public ServiceMenu(int i)
        {
            this.i = i;
        }
        public void StartMenu()
        {
            switch (i)
            {
                case 1:
                        Dz1_1.Dz1(); //Рассчитать и вывести индекс массы тела по формуле I = m / (h * h); где m-масса тела в килограммах, h - рост в метрах
                    break;
                case 2:
                    Dz1_2.StartDz(); //2. Найти максимальное из четырех чисел. Массивы не использовать.
                    break;
                case 12:
                    Dz1_12.Start(); //12.Написать функцию нахождения максимального из трех чисел.
                    break;
                default:
                    break;
            }
        }
        
    }
}
