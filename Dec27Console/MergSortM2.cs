using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec27Console
{
    internal class MergSortM2
    {
        static void MergeSort(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[10];
            int i, left_end, numElements, temPos;
            left_end = (mid - 1);
            temPos = left;
            numElements = (right - left + 1);

            while ((left <= left_end) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                {
                    temp[temPos++] = numbers[left++];
                }
                else
                {
                    temp[temPos++] = numbers[mid++];
                }
            }

            while (left <= left_end)
            {
                temp[temPos++] = numbers[left++];
            }

            while (mid <= right)
            {
                temp[temPos++] = numbers[mid++];
            }

            for (i = 0; i < numElements; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }
        static void SortMethod(int[] numbers, int left, int right)
        {
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;
                SortMethod(numbers, left, mid);
                SortMethod(numbers, (mid + 1), right);
                MergeSort(numbers, left, mid + 1, right);
            }
        }
        static void Main(string[] args)
        {
            int[] numbers = { 27, 43, 9, 82, 10,45, 1, 99, 88 };
            int len = numbers.Length;
            Console.WriteLine("after sort");
            SortMethod(numbers, 0, len - 1);
            foreach (var x in numbers)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();

        }
    }
}
