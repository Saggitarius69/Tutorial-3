using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your age: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int age))
            {
            
                if (age < 13)
                {
                    Console.WriteLine("Child.");
                }
                else if (age < 20)
                {
                    Console.WriteLine("Teenager.");
                }
                else if (age >= 20)
                {
                    Console.WriteLine("Adult.");
                }
            }
            else
            {
                Console.WriteLine("Enter a valid number.");
            }

    }
}