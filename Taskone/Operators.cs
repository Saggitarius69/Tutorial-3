using System;

public class Operators
{
    public void Add(int a, int b)
    {
        Console.WriteLine("Sum: " + (a + b));
    }
    public void Subtract(int a, int b)
    {
        Console.WriteLine("Difference: " + (a - b));
    }
    public void Multiply(int a, int b)
    {
        Console.WriteLine("Product: " + (a * b));
    }
    public void Divide(int a, int b)
    {
        if (b != 0)
        {
            Console.WriteLine("Quotient: " + ((double)a / b));
        }
        else
        {
            Console.WriteLine("Cannot divide by zero.");
        }
    }
    public void OddEvenFinder(int number)
    {
        if (number % 2 == 0)
        {
            Console.WriteLine(number + " is Even.");
        }
        else
        {
            Console.WriteLine(number + " is Odd.");
        }
    }
}
