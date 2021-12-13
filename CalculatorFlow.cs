using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorWithCommand
{
    class CalculatorFlow
    {
        private Calculator _calculator;
        private CalculatorCommand _lastCommand;

        private List<CalculatorCommand> _commandHistory = new List<CalculatorCommand>();

        public CalculatorFlow(Calculator calculator)
        {
            _calculator = calculator;
        }

        public void ExecuteOperation(Operation operation, int value)
        {
            var calcCommand = new CalculatorCommand(_calculator, operation, value);
            calcCommand.Execute();
            _lastCommand = calcCommand;
        }

        public void Undo()
        {
            _lastCommand.UnExecute();
        }

        public void Redo()
        {
            _lastCommand.Execute();
        }
    }
}
