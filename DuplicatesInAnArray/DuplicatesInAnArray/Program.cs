using System;

namespace DuplicatesInAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 1, 3, 6, 6 };
            int arr_size = arr.Length;

            FindDuplicate.PrintRepeating(arr, arr_size);
        }
    }
}
