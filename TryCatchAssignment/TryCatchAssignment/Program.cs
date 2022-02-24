using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TryCatchAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            bool validAnswer = false;
            int age = 0;
            while (!validAnswer)
            {
                Console.WriteLine("\nHow old are you going to be this year?\n");
                validAnswer = int.TryParse(Console.ReadLine(), out age);

                try
                {
                    DateTime now = DateTime.Now;
                    if (!validAnswer)
                    {
                        Console.WriteLine("\nEnter your age as a whole number only.");
                    }
                    else if (age <= 0)
                    {
                        throw new ArgumentException();
                    }
                    else
                    {
                        Console.WriteLine($"\nBased on the age you entered, we caclulated that you were born this year: {now.Year - age}");
                    }

                }
                catch (ArgumentException)
                {
                    Console.WriteLine("\nYou may not enter 0 or a negative number! Please enter in your age.");
                    Console.ReadLine();
                    return;
                }
                catch (Exception)
                {
                    Console.WriteLine("\nYou must have typed in something wrong and an error has occured.");
                    Console.ReadLine();
                    return;
                }
            }
            Console.ReadLine();
        }
    }
}
