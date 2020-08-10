using System;
using System.Collections.Generic;
using System.Text;

namespace DuplicatesInAnArray
{
    class FindDuplicate
    {
        public static void PrintRepeating(int[] arr, int size)
        {
            int i;
            Console.Write("The repeating" +
                           " elements are : ");

            for (i = 0; i < size; i++)
            {
                if (arr[Math.Abs(arr[i])] >= 0)
                {
                    arr[Math.Abs(arr[i])] = -arr[Math.Abs(arr[i])];
                }
                else
                {
                    Console.Write(Math.Abs(arr[i]) + " ");
                }
            }
        }
    }
}
