using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorWithCommand
{
    class CalculatorCommand : Command
    {
        private Operation _operation;
        private int _operand;
        private Calculator _calculator;

        public CalculatorCommand(Calculator calculator, Operation operation, int operand)
        {
            _calculator = calculator;
            _operation = operation;
            _operand = operand;
        }

        public override void Execute()
        {
            _calculator.Calculate(_operation, _operand);
        }

        public override void UnExecute()
        {
            _calculator.Calculate(UndoOperation(_operation), _operand);
        }

        private Operation UndoOperation(Operation operation)
        {
            switch (operation)
            {
                case Operation.Add:
                    return Operation.Substract;
                case Operation.Substract:
                    return Operation.Add;
                case Operation.Multiplication:
                    return Operation.Division;
                case Operation.Division:
                    return Operation.Multiplication;
                default:
                    throw new ArgumentOutOfRangeException(nameof(operation), operation, null);
            }
        }
    }
}
