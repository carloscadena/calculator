using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter some numbers to calculate (Acceptable operators: +, -, x, /) in this format: 4 x 5");
            string input = Console.ReadLine();
            string[] calculate = input.Split(' ');
            if (calculate[1] == "+")
            {
                Add(calculate[0], calculate[2]);
            }
            else if (calculate[1] == "-")
            {
                Subtract(calculate[0], calculate[2]);
            }
            else if (calculate[1] == "x")
            {
                Multiply(calculate[0], calculate[2]);
            }
            else
            {
                Divide(calculate[0], calculate[2]);
            }

        }
        static void Add(string a, string b)
        {
            Console.WriteLine($"The sum of {a} and {b} is {int.Parse(a) + int.Parse(b)}");
        }
        static void Subtract(string a, string b)
        {
            Console.WriteLine($"The difference between {a} and {b} is {int.Parse(a) - int.Parse(b)}");
        }
        static void Multiply(string a, string b)
        {
            Console.WriteLine($"The product of {a} and {b} is {int.Parse(a) * int.Parse(b)}");
        }
        static void Divide(string a, string b)
        {
            Console.WriteLine($"The quotient of {a} and {b} is {int.Parse(a) / int.Parse(b)}");
        }
    }
}
