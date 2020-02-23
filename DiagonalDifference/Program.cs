using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DiagonalDifference
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = DiagonalDifference(arr);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }

        public static int DiagonalDifference(List<List<int>> arr)
        {
            int a = 0;
            int b = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                a += arr[i][i];
                b += arr[i][arr.Count - (i + 1)];
            }

            return Math.Abs(a - b);
        }
    }
}
