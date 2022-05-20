using System;

namespace Calculator
{

    abstract class Calculations
    {

        public double FirstNumber { get; set; }
        public double SecondNumber { get; set; }
        public ConsoleKeyInfo Operator { get; set; }
        public string InputString { get; set; }
        public double Result { get; set; }



        // Performing calculations based on the operator
        // Entered by the user
        public void DoCalculations()
        {

            switch (Operator.Key)
            {
                case ConsoleKey.Add:
                    Result = FirstNumber + SecondNumber;

                    Console.WriteLine($"{FirstNumber} + {SecondNumber} = ");
                    break;

                case ConsoleKey.Subtract:
                    Result = FirstNumber - SecondNumber;

                    Console.WriteLine($"{FirstNumber} - {SecondNumber} = ");
                    break;

                case ConsoleKey.Multiply:
                    Result = FirstNumber * SecondNumber;

                    Console.WriteLine($"{FirstNumber} * {SecondNumber} = ");
                    break;

                case ConsoleKey.Divide:

                    // Check that the number zero is not entered
                    // As a second number when performing a division.

                    while (SecondNumber == 0)
                    {
                        Console.WriteLine("Enter a non-zero divisor: ");
                        Console.Write("Re-Enter number and press enter: ");

                        InputString = Console.ReadLine();
                        Console.Clear();

                        if (double.TryParse(InputString, out double divisorNumber))
                            SecondNumber = divisorNumber;
                    }

                    Result = FirstNumber / SecondNumber;

                    Console.WriteLine($"{FirstNumber} / {SecondNumber} = ");
                    break;

            }


            Console.WriteLine(Environment.NewLine);
            Console.Write(Result);

            FirstNumber = Result;

        }
    }

}
