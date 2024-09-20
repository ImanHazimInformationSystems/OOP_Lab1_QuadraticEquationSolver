using System;

class QuadraticEquationSolver
{
    static void Main(string[] args)
    {
        // Variables for coefficients
        double a, b, c;

        // Input values for a, b, and c
        Console.Write("Enter coefficient a: ");
        a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter coefficient b: ");
        b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter coefficient c: ");
        c = Convert.ToDouble(Console.ReadLine());

        // Calculate discriminant (b^2 - 4ac)
        double discriminant = (b * b) - (4 * a * c);

        // Check for real roots
        if (discriminant < 0)
        {
            Console.WriteLine("The equation has no real roots.");
        }
        else
        {
            // Calculate the two roots using the quadratic formula
            double sqrtDiscriminant = Math.Sqrt(discriminant);

            double root1 = (-b + sqrtDiscriminant) / (2 * a);
            double root2 = (-b - sqrtDiscriminant) / (2 * a);

            // Output the results
            Console.WriteLine($"Root 1: {root1}");
            Console.WriteLine($"Root 2: {root2}");
        }
    }
}
