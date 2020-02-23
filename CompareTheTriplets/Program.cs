using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CompareTheTriplets
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = CompareTriplets(a, b);

            using TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            textWriter.WriteLine(String.Join(" ", result));

            textWriter.Flush();
            textWriter.Close();
        }

        // Complete the compareTriplets function below.
        private static List<int> CompareTriplets(List<int> a, List<int> b)
        {
            var alicePoints = 0;
            var bobPoints = 0;

            for (int i = 0; i < 3; i++)
            {
                if (a[i] > b[i])
                {
                    ++alicePoints;
                }
                else if (a[i] < b[i])
                {
                    ++bobPoints;
                }
            }

            return new List<int> { alicePoints, bobPoints };
        }
    }
}
