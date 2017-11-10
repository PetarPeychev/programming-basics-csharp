using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_03.Sept_2017
{
    class Program
    {
        static void Main(string[] args)
        {
            int oneLev = int.Parse(Console.ReadLine());
            int twoLev = int.Parse(Console.ReadLine());
            int fiveLev = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());
            int potentialSum;

            for (int i = 0; i <= oneLev; i++)
            {
                for (int j = 0; j <= twoLev; j++)
                {
                    for (int k = 0; k <= fiveLev; k++)
                    {
                        potentialSum = i + j * 2 + k * 5;
                        if (potentialSum == sum)
                            Console.WriteLine($"{i} * 1 lv. + {j} * 2 lv. + {k} * 5 lv. = {sum} lv.");
                    }
                }
            }
        }
    }
}
