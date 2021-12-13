using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorWithCommand
{
    class CalculatorFlow
    {
        private readonly Calculator _calculator;
        private CalculatorCommand _lastCommand;

        private readonly List<CalculatorCommand> _commandHistory = new List<CalculatorCommand>();

        public CalculatorFlow(Calculator calculator)
        {
            _calculator = calculator;
        }

        public void ExecuteOperation(Operation operation, int value)
        {
            var calcCommand = new CalculatorCommand(_calculator, operation, value);
            calcCommand.Execute();
            _commandHistory.Add(calcCommand);
        }

        public void Undo()
        {
            var lastCommand = _commandHistory.LastOrDefault();
            if (lastCommand == null) return;

            lastCommand.UnExecute();
            _commandHistory.Remove(lastCommand);
        }

        public void Redo()
        {
            var lastCommand = _commandHistory.LastOrDefault();
            lastCommand?.Execute();
        }
    }
}
