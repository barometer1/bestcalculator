using System;

namespace calculator
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Input();

            bool complete = false;

            do {
                Console.WriteLine("Do you wish to continue computing?");
                string continuance;
                continuance = Console.ReadLine();
                if (continuance == "yes")
                {
                    Input();
                    complete = false;
                } 
                else if (continuance == "no") 
                {
                    Console.WriteLine("OK. ¡Adios!");
                    Console.ReadKey();
                    complete = true;
                } 
                else 
                {
                    Console.WriteLine("Not sure what you mean. Type \"yes\" or \"no\".");
                    complete = false;
                }
            } while (complete == false);
        }
        public static void Input ()
        {
            Console.WriteLine("First number?");
            double num01 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Second number?");
            double num02 = Convert.ToDouble(Console.ReadLine());

            double answer = Compute(num01, num02);

            Console.WriteLine("The result is " + answer);

            Console.ReadKey();
        }
        public static double Compute (double _num01, double _num02)
        {
            bool valid = true;
            double ans = 0;

            do
            {
                valid = true;
                
                Console.WriteLine("Please enter arithmetic operation:");

                string op = Console.ReadLine().ToLower();
                switch (op)
                {
                    case "addition":
                        ans = Addition(_num01, _num02);
                        break;

                    case "subtraction":
                        ans = Subtraction(_num01, _num02);
                        break;

                    case "multiplication":
                        ans = Multiplication(_num01, _num02);
                        break;

                    case "division":
                        ans = Division(_num01, _num02);
                        break;
                    default:
                        Console.WriteLine("Invalid operation.");
                        valid = false;
                        break;
                }
            } while (valid == false);
            return ans;
        }
        public static double Addition (double _num01, double _num02)
        {
            double _answer = (_num01 + _num02);
            return _answer;
        }
        public static double Subtraction (double _num01, double _num02)
        {
            double _answer = (_num01 - _num02);
            return _answer;
        }
        public static double Multiplication (double _num01, double _num02)
        {
            double _answer = (_num01 * _num02);
            return _answer;
        }
        public static double Division (double _num01, double _num02)
        {
            if (_num02 == 0)
            {
                return double.NaN;
            } else {
                double _answer = (_num01 / _num02);
                return _answer;
            }
        }
    }
}
