using System;

namespace CalculatorWithCommand
{
    public class Calculator
    {
        private int _total = 0;

        public void Calculate(Operation operation, int operand)
        {
            switch (operation)
            {
                case Operation.Add: _total += operand; break;
                case Operation.Substract: _total -= operand; break;
                case Operation.Multiplication: _total *= operand; break;
                case Operation.Division: _total /= operand; break;
            }
            Console.WriteLine($"Current value = {_total} (after {operation} {operand})");
        }
    }
}
