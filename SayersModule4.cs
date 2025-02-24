using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        string input1 = Console.ReadLine();

        Console.WriteLine("Enter the second number:");
        string input2 = Console.ReadLine();

        try
        {
            // Convert inputs to integers
            int number1 = Convert.ToInt32(input1);
            int number2 = Convert.ToInt32(input2);

            // Perform division
            int result = Divide(number1, number2);
            Console.WriteLine($"The result of {number1} divided by {number2} is: {result}");
        }
        catch (FormatException ex)
        {
            // Handle invalid input format
            Console.WriteLine("Error: One or both of the inputs are not valid integers.");
            Console.WriteLine($"Detailed error message: {ex.Message}");
        }
        catch (DivideByZeroException ex)
        {
            // Handle division by zero
            Console.WriteLine("Error: Division by zero is not allowed.");
            Console.WriteLine($"Detailed error message: {ex.Message}");
        }
        catch (Exception ex)
        {
            // Handle any other unexpected exceptions
            Console.WriteLine("An unexpected error occurred.");
            Console.WriteLine($"Detailed error message: {ex.Message}");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    // Method for performing division
    static int Divide(int a, int b)
    {
        return a / b;
    }
}
