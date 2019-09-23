using System;
using System.Globalization;
using System.Threading;

namespace CurrenciesLab
{
    class MainClass
    {
        static void Main(string[] args)
        {

            //Declare Variables
            double dollar1;
            double dollar2;
            double dollar3;

            //this is where will store calculations
            double total;
            double average;
            double min;
            double max;

            //Get User Input
            Console.WriteLine("Please Enter a Dollar Amount: $");
            dollar1 = double.Parse(Console.ReadLine());

            //Get User Input
            Console.WriteLine("Please Enter a Dollar Amount: $");
            dollar2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter a Dollar Amount: $");
            dollar3 = double.Parse(Console.ReadLine());

            //Get Total
            total = (dollar1 + dollar2 + dollar3);
            

            //Get Average
            average = ((dollar1 + dollar2 + dollar3) / 3);
        

            //Get Max
            max = Math.Max(dollar1, Math.Max(dollar2, dollar3));

            // Get Min
            min = Math.Min(dollar1, Math.Min(dollar2, dollar3));

            //Print Total, Average, Max and Min

            Console.WriteLine("The Total is: " + total.ToString("C", CultureInfo.CreateSpecificCulture("en-us")));
            Console.WriteLine("The Average is: " + average.ToString("C", CultureInfo.CreateSpecificCulture("en-us")));
            Console.WriteLine("The min is: " + min.ToString("C", CultureInfo.CreateSpecificCulture("en-us")));
            Console.WriteLine("The max is: " + max.ToString("C", CultureInfo.CreateSpecificCulture("en-us")));




            //Print Total in US, Swedish, Japanese and Thai
            Console.WriteLine("The Total in US is: " + total.ToString("C", CultureInfo.CreateSpecificCulture("en-us")));
            Console.WriteLine("The Total in JP is: " + total.ToString("C", CultureInfo.CreateSpecificCulture("ja-jp")));
            Console.WriteLine("The Total in SV is: " + total.ToString("C", CultureInfo.CreateSpecificCulture("sv-se")));
            Console.WriteLine("The Total in TH is: " + total.ToString("C", CultureInfo.CreateSpecificCulture("th-th")));


            Thread.Sleep(5000);

        }

    }
}