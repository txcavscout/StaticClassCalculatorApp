using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassCalculator
{
    public class UserMessages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the basic console calculator app.");
            Console.WriteLine("It will add, subtract, multiply, or divide any two numbers of your choice.");
            Console.WriteLine();
        }

        public static void GoodByeMessage()
        {
            Console.WriteLine();
            Console.WriteLine("Thank you for using this app. Goodbye...");
            System.Threading.Thread.Sleep(5000);
            Console.Clear();
        }
   
    }
}
