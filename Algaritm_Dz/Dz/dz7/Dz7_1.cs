using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Algaritm_Dz.Dz.dz7
{//71. Написать функции, которые считывают матрицу смежности из файла и выводят ее на экран.
    public static class Dz7_1
    {
        public static void Start()
        {

            string masiv;


            using (StreamReader streamReader = new StreamReader("dz7.txt"))
            {
                masiv = streamReader.ReadToEnd();
            }

            int[,] matrix = createMatrix(masiv);
            PrintMatrix(matrix);
        }
        private static int[,] createMatrix(string masiv)
        {
            string[] lines = masiv.Split('\n');
            int rowNumber = lines.Length;
            int columnNumber = lines.First().Split(' ').Length;

            int[,] matrix = new int[rowNumber, columnNumber];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] columns = lines[i].Split(' ');

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = int.Parse(columns[j]);
                }

            }
            return matrix;
        }
      
        private static void PrintMatrix(int[,] someMatrix)
        {
            for (int i = 0; i < someMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < someMatrix.GetLength(1); j++)
                {
                    Console.Write("{0,3} ", someMatrix[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}
