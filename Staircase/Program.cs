using System;
using System.Text;

namespace Staircase
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            Staircase(n);
        }

        private static void Staircase(int n)
        {
            var format = $"{{0,{n}}}";
            var stringbuilder = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                stringbuilder.Append('#');
                Console.WriteLine(format, stringbuilder.ToString());
            }
        }
    }
}
