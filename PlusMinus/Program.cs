using System;
using System.Globalization;

namespace PlusMinus
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            PlusMinus(n, arr);
        }

        // Complete the plusMinus function below.
        private static void PlusMinus(int n, int[] arr)
        {
            double positive = 0;
            double negative = 0;
            double zeros = 0;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] > 0)
                {
                    ++positive;
                }
                else if (arr[i] < 0)
                {
                    ++negative;
                }
                else
                {
                    ++zeros;
                }
            }

            var m = Convert.ToDouble(n);

            double rate = positive / m;
            Console.WriteLine(rate.ToString("N6", CultureInfo.GetCultureInfo("EN-US")));

            rate = negative / m;
            Console.WriteLine(rate.ToString("N6", CultureInfo.GetCultureInfo("EN-US")));

            rate = zeros / m;
            Console.WriteLine(rate.ToString("N6", CultureInfo.GetCultureInfo("EN-US")));
        }
    }
}
