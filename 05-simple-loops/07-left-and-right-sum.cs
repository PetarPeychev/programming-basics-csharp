using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Loops_Exercises
{
    class LeftRightSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < n; i++)
            {
                leftSum += int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                rightSum += int.Parse(Console.ReadLine());
            }

            int diff = Math.Abs(leftSum - rightSum);

            if (diff == 0)
                Console.WriteLine("Yes, sum = " + leftSum);
            else Console.WriteLine("No, diff = " + diff);
        }
    }
}
