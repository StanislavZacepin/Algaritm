using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algaritm_Dz.Dz.dz7
{
    class Dz7_3
	{
        //3. Написать функцию обхода графа в ширину.

# include<stdio.h>

#define MAX_N  10

int a[MAX_N][MAX_N], q[MAX_N], visited[MAX_N], n, i, j, f = 0, r = -1;

		void bfs(int v)
		{
			for (i = 1; i <= n; i++)
				if (a[v][i] && !visited[i])
					q[++r] = i;
			if (f <= r)
			{
				visited[q[f]] = 1;
				bfs(q[f++]);
			}
		}

		void main()
		{
			int v;
			printf("\n Number of vertices:");
			scanf("%d", &n);

			for (i = 1; i <= n; i++)
			{
				q[i] = 0;
				visited[i] = 0;
			}

			printf("\n Enter graph data in matrix form:\n");
			for (i = 1; i <= n; i++)
			{
				for (j = 1; j <= n; j++)
				{
					scanf("%d", &a[i][j]);
				}
			}

			printf("\n Enter the starting vertex:");
			scanf("%d", &v);
			bfs(v);

			for (i = 1; i <= n; i++)
			{
				if (visited[i])
					printf("%d\t", i);
				else
				{
					printf("\n Error");
					break;
				}
			}

			puts("");
			system("pause");
			return 0;
		}
	}
}
