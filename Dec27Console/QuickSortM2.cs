using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec27Console
{
    internal class QuickSortM2
    {
        public static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {
                while (arr[left] < pivot)
                {
                    left++;
                }
                while (arr[right] > pivot)
                {
                    right--;
                }
                if (left < right)
                {
                    if (arr[left] == arr[right])
                    {
                        return right;
                    }
                    else
                    {
                        int temp = arr[left];
                        arr[left] = arr[right];
                        arr[right] = temp;
                    }
                }
                else
                { 
                    return right; 
                }
            }
        }
        static void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot <= 0)
                {
                    QuickSort(arr, left, pivot);
                }

                QuickSort(arr, pivot + 1, right);
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 2, 5, 4, 11, 0, };
            QuickSort(arr, 0, arr.Length - 1);
            //Array.Sort(arr);
            foreach (var x in arr)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();
        }

    }
}
