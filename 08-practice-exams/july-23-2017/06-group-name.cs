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
            char capital = char.Parse(Console.ReadLine());
            char lower1 = char.Parse(Console.ReadLine());
            char lower2 = char.Parse(Console.ReadLine());
            char lower3 = char.Parse(Console.ReadLine());
            int num = int.Parse(Console.ReadLine());
            int sum = -1;

            for (int i = 'A'; i <= capital; i++)
            {
                
                for (int j = 'a'; j <= lower1; j++)
                {
                    
                    for (int k = 'a'; k <= lower2; k++)
                    {
                        
                        for (int l = 'a'; l <= lower3; l++)
                        {

                            for (int m = 0; m <= num; m++)
                            {
                                sum++;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
