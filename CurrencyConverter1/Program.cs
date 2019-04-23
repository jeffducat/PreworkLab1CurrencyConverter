using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CurrencyConverter1
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstAmount;
            double secondAmount;
            double thirdAmount;
            double totalAmount;
            
            Console.Write("What's your first dollar amount? $");
            while (!double.TryParse(Console.ReadLine(), out firstAmount))
            {
                Console.Write("Invalid Entry:  Please enter a numerical value.  What's your first dollar amount? $");
            }
            
            Console.Write("What's your second dollar amount? $");
            while (!double.TryParse(Console.ReadLine(), out secondAmount))
            {
                Console.Write("Invalid Entry:  Please enter a numerical value.  What's your second dollar amount? $");
            }

            Console.Write("What's your third dollar amount? $");
            
            while (!double.TryParse(Console.ReadLine(), out thirdAmount))
            {
                Console.Write("Invalid Entry:  Please enter a numerical value.  What's your third dollar amount? $");
            }

            double[] amountsArray = { firstAmount, secondAmount, thirdAmount };
            totalAmount = amountsArray.Sum();

            Console.WriteLine($"The total of your three amounts is ${amountsArray.Sum()}");

            //bankers round
            Console.WriteLine($"The average of your three amounts is ${Math.Round(amountsArray.Average(), 2)}"); 
 
            Console.WriteLine($"Your smallest dollar amount is ${amountsArray.Min()}");

            Console.WriteLine($"Your largest dollar amount is ${amountsArray.Max()}");

            //For Swedish
            Console.WriteLine("Your total in Swedish Krona is " + totalAmount.ToString("C", CultureInfo.CreateSpecificCulture("sv-SE")));

            //For Japanese
            Console.WriteLine("Your total in Japanes Yen is " + totalAmount.ToString("C", CultureInfo.CreateSpecificCulture("ja-JP")));

            //Updated encoding for Thai Baht symbol
            Console.OutputEncoding = Encoding.UTF8;
            
            //For Thai
            Console.WriteLine("Your total in Thai Baht is " + totalAmount.ToString("C", CultureInfo.CreateSpecificCulture("th")));

            Console.ReadKey();

        }
    }
}
