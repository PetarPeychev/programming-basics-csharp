using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var amount = double.Parse(Console.ReadLine());
            string currencyFrom = Console.ReadLine();
            string currencyTo = Console.ReadLine();
            double convertedAmount = 0;
 
            if (currencyFrom == "BGN")
            {
                if (currencyTo == "USD")
                {
                    convertedAmount = amount / 1.79549;
                }
                else if (currencyTo == "EUR")
                {
                    convertedAmount = amount / 1.95583;
                }
                else if (currencyTo == "GBP")
                {
                    convertedAmount = amount / 2.53405;
                }
                else if (currencyTo == "BGN")
                {
                    convertedAmount = amount;
                }
            }
            else if (currencyFrom == "USD")
            {
                if (currencyTo == "BGN")
                {
                    convertedAmount = amount * 1.79549;
                }
                else if (currencyTo == "USD")
                {
                    convertedAmount = amount;
                }
                else if (currencyTo == "EUR")
                {
                    convertedAmount = amount * 1.79549/ 1.95583;
                }
                else if (currencyTo == "GBP")
                {
                    convertedAmount = amount * 1.79549 / 2.53405;
                }
            }
            else if (currencyFrom == "EUR")
            {
                if (currencyTo == "BGN")
                {
                    convertedAmount = amount * 1.95583;
                }
                else if (currencyTo == "EUR")
                {
                    convertedAmount = amount;
                }
                else if (currencyTo == "USD")
                {
                    convertedAmount = amount * 1.95583 / 1.79549 ;
                }
                else if (currencyTo == "GBP")
                {
                    convertedAmount = amount * 1.95583 / 2.53405;
                }
            }
            else if (currencyFrom == "GBP")
            {
                if (currencyTo == "BGN")
                {
                    convertedAmount = amount * 2.53405;
                }
                else if (currencyTo == "GBP")
                {
                    convertedAmount = amount;
                }
                else if (currencyTo == "USD")
                {
                    convertedAmount = amount * 2.53405 / 1.79549;
                }
                else if (currencyTo == "EUR")
                {
                    convertedAmount = amount * 2.53405 / 1.95583;
                }
            }
            Console.WriteLine($"{convertedAmount:f2} {currencyTo}");
        }
    }
}
