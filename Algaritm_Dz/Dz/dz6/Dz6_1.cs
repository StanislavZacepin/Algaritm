using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Algaritm_Dz.Dz.dz6
{
   static public class Dz6_1
    {
        static public void Start()
        {
            string sSourceData;
            byte[] tmpSource;
            byte[] tmpHash;

            sSourceData = Console.ReadLine();
            tmpSource = ASCIIEncoding.ASCII.GetBytes(sSourceData);
            tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);
            foreach (var item in tmpSource)
            {
                Console.WriteLine(item); 
            }
            Console.WriteLine("____________________");
            foreach (var item in tmpHash)
            {
                Console.WriteLine(item); 
            }
            string xeh="";
            Random rnd = new Random();
            for (int i = 0; i < tmpHash.Length; i++)
            {
                xeh += tmpHash[i];
                xeh += (char)rnd.Next(193, 256);

            }
            Console.WriteLine("____________________");
            
                Console.WriteLine(xeh);
          
        }
    }
}
