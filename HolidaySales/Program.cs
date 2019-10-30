using System;
using static System.Console;

namespace HolidaySales
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Put in Sales Person Initial: ");
            string input = ReadLine();
            string userNum;

            double d = 0;
            double e = 0;
            double f = 0;

            input = input.ToLower();
            while(input != "z")
            {
                if(input == "d")
                {
                    WriteLine("Sale: ");
                    userNum = ReadLine();
                    d = d + Convert.ToDouble(userNum);
                }
                else if(input == "e")
                {
                    WriteLine("Sale: ");
                    userNum = ReadLine();
                    e = e + Convert.ToDouble(userNum);
                }
                else if (input == "f")
                {
                    WriteLine("Sale: ");
                    userNum = ReadLine();
                    f = f + Convert.ToDouble(userNum);
                } 
                else
                {
                    WriteLine("ERRRORRR");
                }

                WriteLine("Put in Sales Person Initial: ");
                input = ReadLine();
                input = input.ToLower(); //don't have to worry if the user put in uppercase

            }

            WriteLine("Danille's Total: {0:C} \n" +
                "Edward Total: {1:C} \n" +
                "Francis Total: {2:C}", d, e, f);

            //alternative way to output sales totals
            //WriteLine("Danille's Total: " + d.ToString("C")); 

            double total = d + e + f;
            WriteLine("Grand Total: " + total.ToString("C"));

            if(d >= e && d >= f)
            {
                if(d==e && d == f)
                {
                    WriteLine("Tie between all sales");
                }
                else if (d == e)
                {
                    WriteLine("Tie between D and E");
                }
                else if (d == f)
                {
                    WriteLine("Tie between D and F");
                }
                else
                {
                    WriteLine("Top sales: Danille with {0:C} sales", d);
                }
            }
            else if (e >= f)
            {
                if ( e == f)
                {
                    WriteLine("Tie between E and F");
                }
                else
                {
                    WriteLine("Top sales: Edward with {0:C} sales", e);
                }
            }
            else
            {
                WriteLine("Top sales: Francis with {0:C} sales", f);
            }



        }
    }
}
