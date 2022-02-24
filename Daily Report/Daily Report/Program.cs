using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Report
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // here this is writing the tech academy and then going down 2 new lines and then writing student daily report and then going down 2
            // more new lines and asking for the name of the user and saving their name into a string var called usrName and then displaying the name on screen using the console.ReadLine()
            Console.WriteLine("The Tech Academy.\n\nStudent Daily Report.\n\nWhat is your name?\n");
            string usrName = Console.ReadLine();
            // here this is asking the user what course they are on currently and then saving that value into another string var. (Console.writeLine is how we get things printed to the terminal)
            Console.WriteLine("What course are you on?\n");
            string courseName = Console.ReadLine();
            // here we are doing that same but asking the page number and then we are taking the value the user inputed and saving it into an int var and converting the user input to a int and displaying it 
            Console.WriteLine("What page number?\n");
            int pgNum = Convert.ToInt32(Console.ReadLine());
            // here we are converting the user input into a boolean(true or fale)
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"\n");
            bool yOrn = Convert.ToBoolean(Console.ReadLine());
            
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.\n");
            string feedback = Console.ReadLine();
            
            Console.WriteLine("How man hours did you study today?\n");
            int hours = Convert.ToInt32(Console.ReadLine());
            // here once all the questions have been answered this will be printed out at the end.
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
            

        }
    }
}
