using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousIncomeComparisonProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program\n");

            Console.WriteLine("Person 1, Please provide the following information below.\n"); // we ask the usr to input the data below
            Console.WriteLine("Hourly Rate: "); // remember \n is to start a new line. Here usr puts in an amount
            decimal p1HrRate = Convert.ToDecimal(Console.ReadLine()); // we convert the rate to decimal so they can put in something like 23.50 for their rate

            Console.WriteLine("\nHours worked per week?"); // we then ask for hours worked and convert it into an int
            int p1hrwrk = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPerson 2, Please provide the following information below.\n"); // here usr 2 puts in their info

            Console.WriteLine("Hourly Rate: ");
            decimal p2HrRate = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("\nHours worked per week?");
            int p2HrWrk = Convert.ToInt32(Console.ReadLine());

            /* this code takes the hours they work each with multiply by their hourly rate and then takes that total and multiplies it by 52(weeks in a year)
            and then gives us their annual salary */
            decimal p1Annual = p1HrRate * p1hrwrk * 52m; 
            decimal p2Annual = p2HrRate * p2HrWrk * 52m; 

            // here we print out the annual salaries of each person
            Console.WriteLine("\nAnnual salary of Person 1:\n" + p1Annual);
            Console.WriteLine("\nAnnual salary of Person 2:\n" + p2Annual);

            // we then make a bool statement saying person 1 anual is greater than person 2's annual and then ask a question that is printed
            bool makesMore = p1Annual > p2Annual;
            Console.WriteLine("\nDoes Person 1 make more money than Person 2?\n" + makesMore); // this will tell us true or false if the above statment is correct

            Console.ReadLine();
        }
    }
}
