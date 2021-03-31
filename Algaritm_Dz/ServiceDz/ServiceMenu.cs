using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algaritm_Dz.Dz.dz1;

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
                        Dz1_1.Dz1();
                    break;  

                default:
                    break;
            }
        }
    }
}
