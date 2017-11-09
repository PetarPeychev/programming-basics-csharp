using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Loops_Exercises
{
    class EqualPairs
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num0 = int.Parse(Console.ReadLine());
            int num1 = int.Parse(Console.ReadLine());
            int preValue = num0 + num1;
            int check = 0;
            int maxDiff = int.MinValue;

            for (int i = 0; i < n - 1; i++)
            {
                int num2 = int.Parse(Console.ReadLine());
                int num3 = int.Parse(Console.ReadLine());
                int value = num2 + num3;

                int diff = Math.Abs(preValue - value);
                if (value != preValue)
                {
                    check = 1;
                    preValue = value;
                }
                if (diff > maxDiff)
                    maxDiff = diff;
            }

            if (check == 0)
                Console.WriteLine("Yes, value=" + preValue);
            else if (check == 1)
                Console.WriteLine("No, maxdiff=" + maxDiff);
        }
    }
}
