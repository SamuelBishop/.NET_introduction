using System;

namespace numbers_in_CSharp
{
    class Program
    {
        static void WorkingWithIntegers() // function
        {
            Console.WriteLine();
            Console.WriteLine($"Integer Examples:");
            // Works exactly like c++ with the object console having object specific functions
            int a = 18;
            int b = 6;
            int c = 3;
            int d = (a + b) / c;
            int e = (a + b) % c;
            // The structure of printing to the console in C#/.NET is $ << "info {variables}
            Console.WriteLine($"quotient: {d}");
            Console.WriteLine($"remainder: {e}");

            int max = int.MaxValue; // same as int = INT_MAX in c++ from climits library
            int min = int.MinValue; // same as int = INT_MIN in C++ from climits library
            Console.WriteLine($"The range of integers is {min} to {max}");

            int what = max + 3;
            Console.WriteLine($"This is what happens when data overflow in C# {what}"); // Notice how it loops to the min overflow!
            

            // NOTE: The order of operations applies the same as C++ or Java

            // addition
            // int c = a + b;
            // Console.WriteLine(c);

            // subtraction
            // c = a - b;
            // Console.WriteLine(c);

            // multiplication
            // c = a * b;
            // Console.WriteLine(c);

            // division
            // c = a / b;
            // Console.WriteLine(c);
        }

        static void WorkingWithDoubles() {
            Console.WriteLine();
            Console.WriteLine($"Double Examples:");
            // Can do all of the same stuff with doubles
            double f = 20;
            double g = 6;
            double h = 3;
            double i = (f + g) / h;
            double j = (f + g) % h;
            Console.WriteLine($"quotient double: {i}");
            Console.WriteLine($"remainder double: {j}");

            double max_d = double.MaxValue;
            double min_d = double.MinValue;
            Console.WriteLine($"double's max value: {max_d}");
            Console.WriteLine($"double's min value: {min_d}");
            // Extra tutorial code not sure why this needed to be specified
            double third = 1.0 / 3.0;
            Console.WriteLine(third);
        }

        static void WorkingWithFixedPointTypes() {
            Console.WriteLine();
            Console.WriteLine($"Fixed Point Examples:");
            decimal min = decimal.MinValue;
            decimal max = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {min} to {max}");
            // The next 6 lines illustrate the differences between doubles and decimals
            double a = 1.0;
            double b = 3.0;
            Console.WriteLine(a / b);
            decimal c = 1.0M; // The M suffix indicates how to use the decimal type
            decimal d = 3.0M; // Notice the decimal type stores many more significant figures (larger data type)
            Console.WriteLine(c / d);
        }

        static void RadiusOfCircle(){
            Console.WriteLine();
            Console.WriteLine($"Radius of Circle Challenge Question:");
            double radius = 2.5; // this is in cm
            double result = Math.PI * radius * radius;
            Console.WriteLine($"The radius of the circle is: {result}");
        }

        static void Main(string[] args) // super similar to java
        {
            WorkingWithIntegers();
            WorkingWithDoubles();
            WorkingWithFixedPointTypes();
            RadiusOfCircle();

        }
    }
}
