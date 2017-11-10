using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());

            int poor = 0;
            int satisfactory = 0;
            int good = 0;
            int veryGood = 0;
            int excellent = 0;
            for (int i = 0; i < students; i++)
            {
                double mark = double.Parse(Console.ReadLine());
                if (mark >= 0 && mark <= 22.5) poor++;
                if (mark > 22.5 && mark <= 40.5) satisfactory++;
                if (mark > 40.5 && mark <= 58.5) good++;
                if (mark > 58.5 && mark <= 76.5) veryGood++;
                if (mark > 76.5 && mark <= 100) excellent++;
            }

            Console.WriteLine("{0:f2}% poor marks", poor * 100.0 / students);
            Console.WriteLine("{0:f2}% satisfactory marks", satisfactory * 100.0 / students);
            Console.WriteLine("{0:f2}% good marks", good * 100.0  / students);
            Console.WriteLine("{0:f2}% very good marks", veryGood * 100.0 / students);
            Console.WriteLine("{0:f2}% excellent marks", excellent * 100.0 / students);

        }
    }
}
