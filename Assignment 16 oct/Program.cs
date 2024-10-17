//Divide by Zero Exception Handling


using System;

class Program
{
    static void Main()
    {
        try
        {
            // Prompt for the first number
            Console.Write("Enter the first number: ");
            double numerator = Convert.ToDouble(Console.ReadLine());

            // Prompt for the second number
            Console.Write("Enter the second number: ");
            double denominator = Convert.ToDouble(Console.ReadLine());

            // Perform the division
            double result = Divide(numerator, denominator);

            // Display the result
            Console.WriteLine($"Result: {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter numeric values.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }

    static double Divide(double numerator, double denominator)
    {
        if (denominator == 0)
        {
            throw new DivideByZeroException();
        }
        return numerator / denominator;
    }
}
