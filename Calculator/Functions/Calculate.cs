using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Functions
{
    internal static class CalculateFunc
    {
        public static double Calculate(string input)
        {
            try
            {
                // Строка конфликта
                char[] operators = new char[] { '+', '-', '*', '/', '%', '^' };
                int opIndex = FindFirstOperatorFunc.FindFirstOperator(input);

                if (opIndex == -1)
                {
                    return ParseOperandFunc.ParseOperand(input);
                }

                string leftString = input.Substring(0, opIndex);
                string rightString = input.Substring(opIndex + 1);

                double left = Calculate(leftString);
                double right = Calculate(rightString);

                char op = input[opIndex];

                return PerformOperationFunc.PerformOperation(left, right, op);
            }
            catch (Exception)
            {
                throw new ArgumentException("Непредвиденная ошибка!");
            }
        }    
    }
}
