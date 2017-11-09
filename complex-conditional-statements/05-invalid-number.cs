using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex_Conditionals_Exercises
{
    class InvalidNumber
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());

            if ((num >= 100 && num <= 200) || num == 0) ;
            else Console.WriteLine("invalid");  
        }
    }
}
