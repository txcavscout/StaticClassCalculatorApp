using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserMessages.WelcomeMessage();

            int operatorChoice = GetUserData.GetMathOperand("Enter your choice.\n1. Add\n2. Subtract\n3. Multiply\n4.Divide: ");

            ProgramLogic.UserChoice(operatorChoice);

            UserMessages.GoodByeMessage();
        }
    }
}
