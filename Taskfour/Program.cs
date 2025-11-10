using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number from 1 to 7: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int dayNumber))
        {
            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Please enter a number between 1 and 7.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Please enter a number.");
        }
    }
}