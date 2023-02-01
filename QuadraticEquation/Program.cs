namespace QuadraticEquation
{
    public class Program
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
            int numberOfRoots = CalculateRoots(a,b,c, out x1, out x2);

            switch (numberOfRoots)
            {
                case 0:
                    Console.WriteLine("The equation has no real roots.");
                    break;
                case 1:
                    Console.WriteLine("The equation has 1 real root: " + x1);
                    break;
                case 2:
                    Console.WriteLine("The equation has 2 real roots: " + x1 + " and " + x2);
                    break;
            }



            Console.ReadKey();



        }
        public static int CalculateRoots(double a, double b, double c, out double x1, out double x2)
        {
            double discriminant = b * b - 4 * a * c;
            if (discriminant < 0)
            {
                x1 = 0;
                x2 = 0;
                return 0;
            }
            else if (discriminant == 0)
            {
                x1 = -b / (2 * a);
                x2 = x1;
                return 1;
            }
            else
            {
                x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                return 2;
            }
        }
    }
}
