using System;

namespace CalculatorWithCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            var calcFlow = new CalculatorFlow(calculator);
            calcFlow.ExecuteOperation(Operation.Add, 5);//5
            calcFlow.ExecuteOperation(Operation.Add, 5);//10
            calcFlow.ExecuteOperation(Operation.Multiplication, 4);//40

            calcFlow.Undo();//10
            calcFlow.Undo();//5
            calcFlow.Redo();//10
            calcFlow.Redo();//15
            calcFlow.Redo();//20




            //var calcCommand = new CalculatorCommand(calculator, Operation.Add, 10);
            //calcCommand.Execute();//10
            //calcCommand.Execute();//20
            //calcCommand.UnExecute();//10

            //calculator.Calculate(Operation.Substract, 1);//9
            //calcCommand.Execute();//19

            //var multiplyCommand = new CalculatorCommand(calculator, Operation.Multiplication, 10);
            //multiplyCommand.Execute();//190
            //calcCommand.UnExecute();//180


            //calculator.Calculate(Operation.Add,10);


            Console.ReadLine();
        }
    }
}
