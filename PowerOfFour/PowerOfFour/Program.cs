using System;

namespace PowerOfFour
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPowerOfFour(16));
        }

        public static bool IsPowerOfFour(int num)
        {
            if (num == 0)
                return false;

            while (num != 1)
            {
                if (num % 4 != 0)
                    return false;
                num = num / 4;
            }
            return true;
        }
    }
}
