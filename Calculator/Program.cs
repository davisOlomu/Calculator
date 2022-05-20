using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(200, 100);
            Console.SetWindowSize(45, 30);


            Console.Title = "Console Calculator";
            CalculatorDisplay.DisplayCalculations();
        }
    }


}
