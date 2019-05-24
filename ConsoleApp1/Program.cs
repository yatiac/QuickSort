using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 81, 60, 57, 83, 61, 72, 76, 84, 16, 35, 58, 15, 88, 65, 32, 21, 6, 34, 74, 12, 95, 96, 94, 33, 1, 40, 100, 82, 80, 71, 55, 3, 89, 97, 51, 90, 24, 10, 38, 86, 54, 19, 28, 93, 91, 23, 27, 63, 4, 17, 85, 2, 18, 31, 70, 99, 68, 41, 62, 92, 53, 8, 73, 59, 45, 20, 67, 39, 25, 30, 14, 5, 36, 50, 52, 44, 77, 69, 26, 22, 49, 66, 47, 56, 43, 42, 37, 46, 75, 11, 48, 13, 78, 64, 79, 29, 87, 9, 7, 98, };
            numbers = sort(numbers);
            numbers.ToList().ForEach(x => Console.Write(x.ToString() + " ,"));
            Console.ReadLine();
        }

        public static int[] sort(int[] numbers)
        {
            if (numbers.Length > 1)
            {
                var split = numbers[RandomNumber(0, numbers.Length)];
                List<int> L = new List<int>(), H = new List<int>();
                foreach (var number in numbers)
                {
                    if (number <= split)
                    {
                        L.Add(number);
                    }
                    else
                    {
                        H.Add(number);
                    }
                }
                int[] x = sort(L.ToArray());
                int[] y = sort(H.ToArray());
                var z = new int[x.Length + y.Length];
                x.CopyTo(z, 0);
                y.CopyTo(z, x.Length);
                numbers = z;
            }
            return numbers;
        }

        public static int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
