using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // prompt user for numbers and operator
            Console.Write("Please enter some numbers to calculate (Acceptable operators: +, -, x, /) in this format: 4 x 5: ");
            string input = Console.ReadLine();
            // split user input into array
            string[] calculate = input.Split(' ');
            // determine what function to call by checking what operator the user input
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
        // Method for adding numbers
        static void Add(string a, string b)
        {
            Console.WriteLine($"The sum of {a} and {b} is {int.Parse(a) + int.Parse(b)}");
        }
        // Method for subtracting numbers
        static void Subtract(string a, string b)
        {
            Console.WriteLine($"The difference between {a} and {b} is {int.Parse(a) - int.Parse(b)}");
        }
        // Method for multiplying numbers
        static void Multiply(string a, string b)
        {
            Console.WriteLine($"The product of {a} and {b} is {int.Parse(a) * int.Parse(b)}");
        }
        // Method for dividing numbers
        static void Divide(string a, string b)
        {
            Console.WriteLine($"The quotient of {a} and {b} is {int.Parse(a) / int.Parse(b)}");
        }
    }
}
