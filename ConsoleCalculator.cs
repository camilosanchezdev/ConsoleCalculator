using Microsoft.VisualBasic.CompilerServices;
using System;

namespace ConsoleCalculator
{
    class Program
    {
        public void Operations(double a, double b)
        {
            char opc = ' ';
            char op = '+';
            double result = 0;
            // Input operation
            Console.WriteLine("Choose an option from the followgin list: ");
            Console.WriteLine("a - Add" + "\ns - Substract" + "\nm - Multiply" + "\nd - Divide");
            int pass;
            do
            {
                Console.Write("Operation: ");
                opc = char.Parse(Console.ReadLine());
                // Check valid option
                if (opc != 'a' && opc != 's' && opc != 'm' && opc != 'd')
                {
                    Console.WriteLine("Choose a valid option");
                    pass = 0;
                }
                else
                    pass = 1;
            } while (pass != 1);
            
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
        }
        public void Interface()
        {
            // Variables
            double a, b;
            char answer = ' ';
            do
            {
                Console.Clear();
                // Start
                Console.WriteLine("Console Calculator");
                Console.WriteLine("==================");
                // Input numbers
                Console.WriteLine("Type a number and then press Enter");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Type another number and then press Enter");
                b = double.Parse(Console.ReadLine());
                Program calc = new Program();
                calc.Operations(a, b);
                do
                {
                    Console.WriteLine("\nDo you want to make another operation? y/n");
                    Console.Write("You answer: ");
                    answer = char.Parse(Console.ReadLine());
                } while (answer != 'y' && answer != 'n');
            } while (answer != 'n');
            Console.Clear();
            Console.WriteLine("Console Calculator");
            Console.WriteLine("==================");
            Console.WriteLine("Good Bye!");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Program inter = new Program();
            inter.Interface();
        }
    }
}
