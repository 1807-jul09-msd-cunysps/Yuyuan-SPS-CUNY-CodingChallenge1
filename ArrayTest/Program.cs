using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTest
{
    class Program
    {
        static void Main(string[] args)
        {
            const int r = 2, c = 2;
            int[,] m1 = new int[r, c] { { 2, 1 }, { 3, 2 } };
            int[,] m2 = new int[r, c] { { 3, 2 }, { 3, 4 } };
            int[,] a = new int[r, c] { { 0, 0 }, { 0, 0 } };
            for (int i = 0; i < m1.GetLength(0); ++i)
            {
                for (int j = 0; j < m2.GetLength(1); ++j)
                {
                    int ans = 0;
                    for (int k = 0; k < m1.GetLength(1); ++k)
                    {
                        ans += m1[i, k] * m2[k, j];
                    }
                    Console.Write((a[i, j] = ans) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
