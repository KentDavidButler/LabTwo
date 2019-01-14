//Code Writen By Kent Butler
//Date written 1/14/2019

using System;

namespace Unit2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool again = true;
            while (again)
            {
                string input;
                double length, width, height;

                Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");
                Console.Write("Enter Length: ");
                length = double.Parse(Console.ReadLine());
                Console.Write("Enter Width: ");
                width = double.Parse(Console.ReadLine());
                Console.Write("Enter Height: ");
                height = double.Parse(Console.ReadLine());

                Console.WriteLine("Area: " + length * width);
                Console.WriteLine("Perimeter: " + (length * 2) + (width * 2));
                Console.WriteLine("Volume: " + length * width * height);

                Console.Write("Continue? (y/n):");
                input = Console.ReadLine().ToLower();
                if (String.Equals("n",input))
                {
                    again = false;
                    Console.WriteLine("Goodbye.");
                }
                else if (String.Equals("y", input))
                {
                    Console.WriteLine("Starting Over.");
                }
                else
                {
                    Console.WriteLine("Invalid Entry! Ending Program.");
                    again = false;
                }

            }

        }
    }
}
