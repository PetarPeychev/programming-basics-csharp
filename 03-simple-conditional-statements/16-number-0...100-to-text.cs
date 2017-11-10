using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_0_100_to_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            int leftPart = number / 10;
            int rightPart = number % 10;
            string text = "";
            string leftText = "";
            string rightText = "";
            //Console.WriteLine($"{leftPart}{rightPart}");
           
            if (rightPart == 0) rightText = "";
            else if (rightPart == 1) rightText = "one";
            else if (rightPart == 2) rightText = "two";
            else if (rightPart == 3) rightText = "three";
            else if (rightPart == 4) rightText = "four";
            else if (rightPart == 5) rightText = "five";
            else if (rightPart == 6) rightText = "six";
            else if (rightPart == 7) rightText = "seven";
            else if (rightPart == 8) rightText = "eight";
            else if (rightPart == 9) rightText = "nine";

            if (leftPart == 1) leftText = "teen";
            else if (leftPart == 2) leftText = "twenty";
            else if (leftPart == 3) leftText = "thirty";
            else if (leftPart == 4) leftText = "forty";
            else if (leftPart == 5) leftText = "fifty";
            else if (leftPart == 6) leftText = "sixty";
            else if (leftPart == 7) leftText = "seventy";
            else if (leftPart == 8) leftText = "eighty";
            else if (leftPart == 9) leftText = "ninety";

            if (number == 0) text = "zero";
            else if (number >= 1 && number < 10) text = rightText;
            else if (number >= 10 && number < 16)
            {
                if (number == 10) text = "ten";
                else if (number == 11) text = "eleven";
                else if (number == 12) text = "twelve";
                else if (number == 13) text = "thirteen";
                else if (number == 14) text = "forteen";
                else if (number == 15) text = "fifteen";
            }
            else if (number >= 16 && number < 20) text = rightText + leftText;
            else if (number >= 20 && number < 100)
            {
                if (rightPart == 0)text = leftText + rightText;
                else text = leftText + " " + rightText;
            }
            else if (number == 100) text = "one hundred";
            else text = "invalid number";

            Console.WriteLine(text);
        }
    }
}
