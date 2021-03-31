using System;
using Algaritm_Dz.ServiceDz;

namespace Algaritm_Dz
{
    class Program
    {
        static void Main(string[] args)
        {
            int selection;
            ServiceMenu serviceMenu;

            Console.WriteLine("Ведите число дз которое вас интересует. Выход когда видете 0");
            do
            {
                selection = int.Parse(Console.ReadLine());
                serviceMenu = new ServiceMenu(selection);
                if (selection != 0) serviceMenu.StartMenu();


            } while (selection != 0);
            




        }
    }
}
