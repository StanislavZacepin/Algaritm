using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algaritm_Dz.Dz.dz1
{ //3. Написать программу обмена значениями двух целочисленных переменных:
   // a.с использованием третьей переменной;
   // b. * без использования третьей переменной.
    class Dz1_3
    {
        #region ***  первая часть задания  
        void A()
        {
            int a = 2;
            int b = 5;
            int c;


            c = b;
            b = a;
            a = c;

        }    
        #endregion *** 

        #region ***  вторая часть задания
        void B()
        {
            int a = 3, b = 7;

            a = a + b;
            b = a - b;
            a = a - b;
        }       
           #endregion *** конец
    }
}
