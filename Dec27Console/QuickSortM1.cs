using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec27Console
{
    internal class QuickSortM1
    {
        static void Swap(int[] arr, int i, int j) { 
            int temp = arr[i]; 
            arr[i] = arr[j]; 
            arr[j] = temp; 
        }
        static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high]; 
            int i = (low - 1);
            for (int j = low; j <= high - 1; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }
            Swap(arr, i + 1, high);
            return (i + 1);
        }
        static void QuickSortFun(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int p = Partition(arr, low, high);
                QuickSortFun(arr, low, p - 1);
                QuickSortFun(arr, p + 1, high);
            }
        }
        static void Print(int[] arr, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 68, 49, 95, 22, 73 };
            int n = arr.Length;
            Console.WriteLine("Unsorted Array");
            Print(arr, n);
            QuickSortFun(arr, 0, n - 1);
            Console.WriteLine("QuickSort Array O/p");
            Print(arr, n);
            Console.ReadLine();
        }

    }
}
