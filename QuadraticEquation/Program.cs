using System;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quadratic equation: ax^2 + bx + c = 0");
            Console.WriteLine("Enter a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter c:");
            double c = double.Parse(Console.ReadLine());

            double delta = b * b - 4 * a * c;
            double x1, x2;

            if (delta > 0)
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("The roots are real and different.");
                Console.WriteLine("x1 = {0}, x2 = {1}", x1, x2);
            }
            else if (delta == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine("The roots are real and same.");
                Console.WriteLine("x1 = x2 = {0}", x1);
            }
            else
            {
                Console.WriteLine("The roots are complex and different.");
            }

            Console.ReadKey();


        }
    }
}
