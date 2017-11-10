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
           double incomeLeva = double.Parse(Console.ReadLine());
           double averageGrade = double.Parse(Console.ReadLine());
           double minIncomeLeva = double.Parse(Console.ReadLine());

            double socialStipend = 0.0;
            double gradeStipend = 0.0;

            if (incomeLeva < minIncomeLeva && averageGrade >= 4.50)
            {
                socialStipend = Math.Floor(35.0 * minIncomeLeva / 100.0);
            }

            if (averageGrade >= 5.50)
            {
                gradeStipend = Math.Floor(averageGrade * 25.0);
            }

            if (socialStipend > gradeStipend && socialStipend != 0)
            {
                Console.WriteLine("You get a Social scholarship {0} BGN", socialStipend);
            }
            else if (gradeStipend >= socialStipend && gradeStipend != 0)
            {
                Console.WriteLine("You get a scholarship for excellent results {0} BGN", gradeStipend);
            }
            else Console.WriteLine("You cannot get a scholarship!");
        }
    }
}
