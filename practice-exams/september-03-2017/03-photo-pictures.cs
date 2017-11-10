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
            int numberPhotos = int.Parse(Console.ReadLine());
            string photoType = Console.ReadLine();
            string orderType = Console.ReadLine();

            double iniPrice = 0.0;

            if (photoType == "9X13")
            {
                if (numberPhotos >= 50)
                    iniPrice = numberPhotos * 0.16 * 0.95;
                else
                    iniPrice = numberPhotos * 0.16;
            }
            else if (photoType == "10X15")
            {
                if (numberPhotos >= 80)
                    iniPrice = numberPhotos * 0.16 * 0.97;
                else
                    iniPrice = numberPhotos * 0.16;
            }
            else if (photoType == "13X18")
            {
                if (numberPhotos > 100)
                    iniPrice = numberPhotos * 0.38 * 0.95;
                else if (numberPhotos >= 50)
                    iniPrice = numberPhotos * 0.38 * 0.97;
                else
                    iniPrice = numberPhotos * 0.38;
            }
            else if (photoType == "20X30")
            {
                if(numberPhotos > 50)
                    iniPrice = numberPhotos * 2.90 * 0.91;
                else if (numberPhotos >= 10)
                    iniPrice = numberPhotos * 2.90 * 0.93;
                else
                    iniPrice = numberPhotos * 2.90;
            }

            if (orderType == "online") iniPrice *= 0.98;

            Console.WriteLine("{0:f2}BGN", iniPrice);
        }
    }
}
