using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Algaritm_Dz.ServiceDz
{
    public class ListMenu
    {
        private string listDz = "listDz.txt";
        private string[] massivDZ { get; set; }
        public void createList()
        {

            using (StreamReader reader = new StreamReader(listDz))
            {
                while (!reader.EndOfStream)
                {
                    massivDZ = reader.ReadLine().Split(';');
                }
            }
        }
                
        public void Printer()
        {
            foreach (var item in massivDZ)
            {
                Console.WriteLine(item);
            }
        }
    }
}