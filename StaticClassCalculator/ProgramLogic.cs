using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassCalculator
{
    public class ProgramLogic
    {
        public static void UserChoice(int choice)
        {
            switch (choice)
            {
                case 1:  double xSum = GetUserData.GetaDouble("Enter the first number to add: ");
                         double ySum = GetUserData.GetaDouble("Enter the second number to add: ");
                         Console.WriteLine();
                         Console.WriteLine($"The result of {xSum} + {ySum} = {xSum + ySum}");

                    break;

                case 2: double xSubtract = GetUserData.GetaDouble("Enter the first number to subtract: ");
                        double ySubtract = GetUserData.GetaDouble("Enter the second number to subtract: ");
                        Console.WriteLine();
                        Console.WriteLine($"The result of {xSubtract} - {ySubtract} = {xSubtract - ySubtract}");


                    break;

                case 3:
                    double xMultiply = GetUserData.GetaDouble("Enter the first number to multiply: ");
                    double yMultiply = GetUserData.GetaDouble("Enter the second number to multiply: ");
                    Console.WriteLine();
                    Console.WriteLine($"The result of {xMultiply} * {yMultiply} = {xMultiply * yMultiply}");

                    break;

                case 4:
                    double xDivide = GetUserData.GetaDouble("Enter the first number to divide: ");
                    double yDivide = GetUserData.GetaDouble("Enter the second number to divide by: ");
                    Console.WriteLine();
                    Console.WriteLine($"The result of {xDivide} / {yDivide} = {xDivide / yDivide}");

                    break;
            }
        }

    }
}
