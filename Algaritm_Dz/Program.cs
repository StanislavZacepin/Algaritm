using System;
using Algaritm_Dz.ServiceDz;

namespace Algaritm_Dz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Зацепин Cтанислав");

            Console.ForegroundColor = ConsoleColor.White;
         
            int selection;
            ServiceMenu serviceMenu;
            ListMenu listMenu = new ListMenu();
            listMenu.createList();
            listMenu.Printer();

            do
            {
                
               
                Console.WriteLine("Ведите номер дз которое вас интересует. Выход когда видете 0");
                
                try
                {
                    selection = int.Parse(Console.ReadLine());
                    serviceMenu = new ServiceMenu(selection);
                    if (selection != 0) serviceMenu.StartMenu();
                }
                catch (Exception)
                {
                    selection = 0;
                    Console.WriteLine("Неверный формат");
                }
              


            } while (selection != 0);
            




        }
    }
}
