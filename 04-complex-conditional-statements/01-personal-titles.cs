using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex_Conditionals_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();

            if (age >= 16)
            {
                if (gender == "m")
                    Console.WriteLine("Mr.");
                else
                    Console.WriteLine("Ms.");
            }
            else
            {
                if (gender == "m")
                    Console.WriteLine("Master");
                else
                    Console.WriteLine("Miss");
            }
        }
    }
}
