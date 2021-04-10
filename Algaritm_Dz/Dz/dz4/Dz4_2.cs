using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algaritm_Dz.Dz.dz4
{
   public static class Dz4_2
    {
		static int i, j, m, n;
		static int[,] c = new int [20,20];
		static char[] x = new char[20];
		static char[] y = new char[20];
		static char[,] b = new char[20,20];
		//static void printer(int[,] mass, int n, int m)
		//{

		//	for (int i = 0; i < n; i++)
		//	{
		//		for (int j = 0; j < m; j++)
		//		{
		//			Console.Write(String.Format(" {0,3} ", mass[i, j]));

		//		}
		//		Console.WriteLine();
		//	}
		//	Console.WriteLine("------------------------------");
		//}
		static void  print(int i, int j)
		{
			if (i == 0 || j == 0)
				return;
			if (b[i,j] == 'c')
			{
				print(i - 1, j - 1);
                Console.WriteLine("%c", x[i - 1]);
			}
			else if (b[i,j] == 'u')
				Console.WriteLine((i - 1).ToString(), j);
			else
				Console.WriteLine(i.ToString(), j - 1);
		}

		static void lcs()
		{
			m = x.Length;
			n = y.Length;
			for (i = 0; i <= m; i++)
				c[i,0] = 0;
			for (i = 0; i <= n; i++)
				c[0,i] = 0;

			//c, u Рё l РѕР±РѕР·РЅР°С‡Р°СЋС‚ РїРѕРїРµСЂРµС‡РЅРѕРµ, РІРѕСЃС…РѕРґСЏС‰РµРµ Рё РЅРёСЃС…РѕРґСЏС‰РµРµ РЅР°РїСЂР°РІР»РµРЅРёСЏ СЃРѕРѕС‚РІРµС‚СЃС‚РІРµРЅРЅРѕ(cross upper left)
			//m - РґР»РёРЅР° РїРµСЂРІРѕР№ СЃС‚СЂРѕРєРё
			//n - РґР»РёРЅР° РІС‚РѕСЂРѕР№ СЃС‚СЂРѕРєРё
			for (i = 1; i <= m; i++)
				for (j = 1; j <= n; j++)
				{
					if (x[i - 1] == y[j - 1])
					{
						c[i,j] = c[i - 1,j - 1] + 1;
						b[i,j] = 'c';
					}
					else if (c[i - 1,j] >= c[i,j - 1])
					{
						c[i,j] = c[i - 1,j];
						b[i,j] = 'u';
					}
					else
					{
						c[i,j] = c[i,j - 1];
						b[i,j] = 'l';
					}
				}
		}

	 public static void Start()
		{
			Console.WriteLine("Enter 1st sequence:");
			string text = Console.ReadLine();
			
			x = text.ToCharArray();
			Console.WriteLine("Enter 2nd sequence:");
			string text2 = Console.ReadLine();
			y = text2.ToCharArray();
			Console.WriteLine("The Longest Common Subsequence is ");
			lcs();
			print(m, n);
			
			
		}
	}
}
