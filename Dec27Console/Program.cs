using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec27Console
{
    internal class Program
    {
        static int ShelSort(int[] arr)
        {
            int len = arr.Length;
            for (int h = len / 2; h > 0; h /= 2)
            {
                for (int i = h; i < len; i += i)
                {
                    int temp = arr[i];
                    int j;
                    for (j = i; j >= h && arr[j - h] > temp; j -= h)
                    {
                        arr[j] = arr[j - h];
                    }
                    arr[j] = temp;
                }
            }
            return 0;
        }
        static void PrintShellSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(" unsorted array");
            int[] arr = { 28, 33, 99, 45, 20, 10, 11 };
            ShelSort(arr);
            PrintShellSort(arr);
            Console.ReadLine();
        }
    }
}
