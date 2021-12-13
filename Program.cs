using System;

namespace CalculatorWithCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            calculator.Calculate(Operation.Add,10);
            calculator.Calculate(Operation.Substract, 1);

            Console.ReadLine();
        }
    }
}
