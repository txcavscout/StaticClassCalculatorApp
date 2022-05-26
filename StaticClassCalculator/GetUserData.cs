using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassCalculator
{
    public class GetUserData
    {
        public static int GetMathOperand(string message)
        {
            Console.Write(message);
            string numberText = Console.ReadLine();
            int operandChoice;

            bool isInt = int.TryParse(numberText, out operandChoice);

            while (isInt == false || operandChoice <= 0 || operandChoice > 4)
            {
                Console.Clear();
                Console.WriteLine("That was not a valid number! Please try again.");
                Console.Write(message);
                numberText = Console.ReadLine();

                isInt = int.TryParse(numberText, out operandChoice);
            }

            return operandChoice;
        }

        public static double GetaDouble(string message)
        {
            Console.Write(message);
            string numberText = Console.ReadLine();
            double output;

            bool isDouble = double.TryParse(numberText, out output);

            while (isDouble == false)
            {
                Console.WriteLine("That was not a valid number! Please try again.");
                Console.Write(message);
                numberText = Console.ReadLine();

                isDouble = double.TryParse(numberText, out output);
            }

            return output;
        }

    }
}
