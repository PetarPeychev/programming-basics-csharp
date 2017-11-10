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
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                Console.WriteLine($"{new string('.', i - 1)}*{new string('.', n - i + 1)}*{new string('.', n - i + 1)}*{new string('.', i - 1)}");
            }
            Console.WriteLine($"{new string('.', n - 1)}*****{new string('.', n - 1)}");
            Console.WriteLine(new string('*', 2 * n + 3));
            Console.WriteLine($"{new string('.', n - 1)}*****{new string('.', n - 1)}");
            for (int i = n; i > 1; i--)
            {
                Console.WriteLine($"{new string('.', i - 2)}*{new string('.', n - i + 2)}*{new string('.', n - i + 2)}*{new string('.', i - 2)}");
            }
        }
    }
}
