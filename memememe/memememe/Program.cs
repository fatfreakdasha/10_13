using System;

namespace memememe
{
    class Program
    {
        static bool IsPerfectSquare(int x)
        {
            return Math.Sqrt(x) % 1 == 0;
        }

        static void Main()
        {
            int n;
            Console.WriteLine("введите число:");
            n = Convert.ToInt32(Console.ReadLine());

            int countNumbers = 0;
            for (int i = 1; i <= n; i++)
            {
                if (IsPerfectSquare(i))
                    ++countNumbers;

            }
            Console.Write("количество чисел,являющиеся полными квадратами: {0}", countNumbers);
            Console.ReadLine();
        }
    }
}