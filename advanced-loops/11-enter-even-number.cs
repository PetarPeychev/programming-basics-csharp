using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.EnterEven
{
    class EnterEven
    {
        static void Main(string[] args)
        {
            int n;
            while (true)
            {
                Console.Write("Enter even number: ");
                n = int.Parse(Console.ReadLine());
                if (n % 2 == 0)
                    break; 
                Console.WriteLine("The number is not even.");
            }

            Console.WriteLine("Even number entered: {0}", n);

        }
    }
}
