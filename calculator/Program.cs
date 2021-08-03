using System;

namespace calculator
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Input ();
        }
        
        public static void GetOper(double _num01, double _num02)
        {
            bool reached = true;
            do
            {
                Console.WriteLine("What operation are you calculating? Type \"help\" for options.");
            
                string operation = Console.ReadLine();

                switch (operation.ToLower())
                {
                case "addition":
                    Console.WriteLine("The answer is: " + _num01 + _num02);
                    reached = true;
                    break;
                case "subtraction":
                    Console.WriteLine("The answer is: " + (_num01 - _num02) );
                    reached = true;
                    break;
                case "multiplication":
                    Console.WriteLine("The answer is: " + _num01 * _num02);
                    reached = true;
                    break;
                case "division":
                    Console.WriteLine("The answer is: " + ((double)_num01 / (double)_num02));
                    reached = true;
                    break;
                default:
                    Console.WriteLine("Available operators are addition, subtraction, multiplication, and division.");
                    reached = false;
                    break;
                }  
            } while (reached == false);
            
        }
        public static void Input ()
        {
            Console.WriteLine("What's the first number?");
            double num01 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What's the second number?");
            double num02 = Convert.ToDouble(Console.ReadLine());

            GetOper(num01, num02);

            Console.WriteLine("Do you wish to continue calculating?");

            string continuance = Console.ReadLine();

            if (continuance.ToLower() == "yes")
            {
                Input ();
            } else {
                Console.WriteLine("Thanks for calculating!");
            }

            Console.ReadKey();
        }
    }
}
