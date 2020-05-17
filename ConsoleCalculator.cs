using Microsoft.VisualBasic.CompilerServices;
using System;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
           
            // Variables
            double a, b;
            char opc = ' ';
            char op = '+';
            double result = 0;
            // Start
            Console.WriteLine("Console Calculator");
            Console.WriteLine("==================");
            // Input numbers
            Console.WriteLine("Type a number and then press Enter");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Type another number and then press Enter");
            b = double.Parse(Console.ReadLine());
            // Input operation
            Console.WriteLine("Choose an option from the followgin list: ");
            Console.WriteLine("a - Add" + "\ns - Substract" + "\nm - Multiply" + "\nd - Divide");
            Console.Write("Operation: ");
            opc = char.Parse(Console.ReadLine());
            switch (opc)
            {
                case 'a':
                    result = a + b;
                    break;
                case 's':
                    result = a - b;
                    op = '-';
                    break;
                case 'm':
                    result = a * b;
                    op = '*';
                    break;
                case 'd':
                    result = a / b;
                    op = '/';
                    break;
            }
            // Result
            Console.WriteLine("Result: {0} {1} {2} = {3}", a, op, b, result);
            Console.ReadKey();
          

        }
    }
}
