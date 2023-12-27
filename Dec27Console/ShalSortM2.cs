using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec27Console
{
    internal class ShalSortM2
    {
        static void Swap(ref int a, ref int b)
        { var t = a; a = b; b = t; }
        static int[] ShellSort(int[] arr)
        {
            var d = arr.Length - 1;
            while (d >= 1)
            {
                for (var i = d; i < arr.Length; i++)
                {
                    var j = i;
                    while ((j >= d) && arr[j - d] > arr[j])
                    {
                        Swap(ref arr[j], ref arr[j - d]);
                        j = j - d;
                    }
                }
                d = d / 2;
            }
            return arr;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Array Values");
            var s = Console.ReadLine().Split(new[] { "", ",", ";" }, StringSplitOptions.RemoveEmptyEntries);
            var arr = new int[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                arr[i] = Convert.ToInt32(s[i]);
            }
            Console.WriteLine("Sorted Array:\n{0}", string.Join(",", ShellSort(arr)));
            Console.ReadLine();
        }
    }
}
