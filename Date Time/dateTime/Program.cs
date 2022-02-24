using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace dateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now); // here we print the current time
            Console.WriteLine("\nGive me a number:\n"); // ask usr to give us a number
            int usrNumber = Convert.ToInt32(Console.ReadLine()); // save number into an int var

            DateTime now = DateTime.Now; // make time now into a var
            DateTime later = now.AddHours(usrNumber); // this is how we add the users number to the current time to get the exaxt time it will be x amount of hours later

            Console.WriteLine($"\nThe current time is {now} but {usrNumber} hours from now it will be: {later}"); // print statement
            Console.ReadLine();

        }
    }
}
