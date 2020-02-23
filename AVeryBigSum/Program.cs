using System;
using System.IO;

namespace AVeryBigSum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using TextWriter textWriter = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            int arCount = Convert.ToInt32(Console.ReadLine());

            long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp));
            long result = AVeryBigSum(ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }

        private static long AVeryBigSum(long[] ar)
        {
            long sum = 0;
            
            foreach (var a in ar)
            {
                sum += a;
            }

            return sum;
        }
    }
}
