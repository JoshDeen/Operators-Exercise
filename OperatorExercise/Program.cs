namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            int a = 17;
            int b = 4;
            int sum = a + b;
            int subtract = a - b;
            int multiply = a * b;
            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine($"{a} + {b} = {sum}");
            Console.WriteLine($"{a} - {b} = {subtract}");
            Console.WriteLine($"{a} * {b} = {multiply}");
            Console.WriteLine($"{a} / {b} = {quotient}");
            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");

            Console.WriteLine();

            AreaOfCircle();

        }

        public static double AreaOfCircle()

        {
            Console.WriteLine("What is the radius of your circle?");

            double radius = double.Parse(Console.ReadLine());

            double area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine();

            Console.WriteLine($"The area of a circle with radius of {radius} is {area}");

            return area;

        }
    }
}
