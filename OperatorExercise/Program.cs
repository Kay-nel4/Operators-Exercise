namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int variable = a % b;
            Console.WriteLine($"{a}/{b} is {quotient} remainder {variable}!");
            AreaOfACircle();
        }

        public static void AreaOfACircle()
        {
            Console.WriteLine("What size is your circle.");
            var radius = double.Parse(Console.ReadLine());
            var area = Math.PI * radius * radius;
            Console.WriteLine($"The area of a circle with a radius of {radius} is {area}.\nPress any key to continue.");
            Console.ReadKey();
        }
    }
}
