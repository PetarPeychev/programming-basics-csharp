using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Loops_Exercises
{
    class HalfSumElement
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
                if (num > max)
                    max = num;
            }

            if (sum - max == max)
            {
                int endSum = sum - max;
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + endSum);
            }
            else
            {
                int diff = Math.Abs(sum - max * 2);
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + diff);
            }

        }
    }
}
