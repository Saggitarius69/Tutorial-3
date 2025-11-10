using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1. Convert Number");
        Console.WriteLine("2. Validate Password");
        Console.Write("Enter your input: ");

        string choiceInput = Console.ReadLine();
        Console.WriteLine();

        switch (choiceInput)
        {
            case "1":
                ConvertNumber();
                break;
            case "2":
                ValidatePassword();
                break;
            default:
                Console.WriteLine("Invalid choice! Program exiting.");
                break;
        }
    }

    static void ConvertNumber()
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();

        try
        {
            int number = int.Parse(input);
            Console.WriteLine("You entered: " + number);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number format");
        }
        finally
        {
            Console.WriteLine("Program Executed");
        }
    }

    static void ValidatePassword()
    {
        Console.Write("Enter a password: ");
        string password = Console.ReadLine();

        try
        {
            if (password.Length < 6)
            {
                throw new Exception("Password must be at least 6 characters.");
            }
            else
            {
                Console.WriteLine("Password satisfied the requirement");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}