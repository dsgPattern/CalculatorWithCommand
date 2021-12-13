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
            throw new NotImplementedException();
        }

        public override void UnExecute()
        {
            throw new NotImplementedException();
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
