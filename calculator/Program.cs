using System;

namespace calculator
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Input();

        }
        public static void Input ()
        {
            Console.WriteLine("First number?");
            double num01 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Second number?");
            double num02 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Which operation are you calculating?");
            var oper = Console.ReadLine();

            double answer = Compute(oper, num01, num02);

            Output(answer);
        }
        public static double Compute (string _oper, double _num01, double _num02)
        {
            double _answer;
            switch (_oper.ToLower())
            {
                case "addition":
                    _answer = Addition(_num01, _num02);
                    return _answer;
                case "subtraction":
                    _answer = Subtraction(_num01, _num02);
                    return _answer;
                case "multiplication":
                    _answer = Multiplication(_num01, _num02);
                    return _answer;
                case "division":
                    if (_num01 != 0)
                    {
                        _answer = Division(_num01, _num02);
                        return _answer;
                    } else {
                        return double.NaN;
                    }
                default:
                    throw new ArgumentException("Available operations are addition, subtraction, multiplication, and division");
            }
        }
        public static void Output (double _answer)
        {
            Console.Write("The answer is " + _answer);
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
            double _answer = (_num01 / _num02);
            return _answer;
        }
    }
}
