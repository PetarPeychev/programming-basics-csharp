using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002.ThreeBrothers
{
    class ThreeBrothers
    {
        static void Main(string[] args)
        {
            double firstBrotherTime = double.Parse(Console.ReadLine());
            double secondBrotherTime = double.Parse(Console.ReadLine());
            double thirdBrotherTime = double.Parse(Console.ReadLine());
            double fatherFishingTime = double.Parse(Console.ReadLine());

            double togetherTime = 1 / (1 / firstBrotherTime + 1 / secondBrotherTime + 1 / thirdBrotherTime);
            double togetherTimeWithBreak = togetherTime * 1.15;

            if (fatherFishingTime - togetherTimeWithBreak > 0)
            {
                Console.WriteLine("Cleaning time: {0:f2}", togetherTimeWithBreak);
                Console.WriteLine("Yes, there is a surprise - time left -> {0} hours.",
                    Math.Floor(fatherFishingTime - togetherTimeWithBreak));
            }
            else
            {
                Console.WriteLine("Cleaning time: {0:f2}", togetherTimeWithBreak);
                Console.WriteLine("No, there isn't a surprise - shortage of time -> {0} hours.",
                    Math.Ceiling(togetherTimeWithBreak - fatherFishingTime));
            }
                
        }
    }
}
