using System;
using System.Linq;

namespace DCP
{
    class Program
    {
        static int[] array = new int[] { 10, 5, 2, 7, 8, 7 };
        static int k = 3;
        static void Main(string[] args)
        {
            FindMax(array, k, array.Length);
        }

        public static void FindMax(int[] array, int k, int n)
        {
            int max;
            for (int i = 0; i <= n - k; i++)
            {
                max = array[i];

                for (int j = 1; j < k; j++)
                {
                    if (array[i + j] > max)
                        max = array[i + j];
                }
                Console.Write(max + " ");
            }

        }
    }
}
