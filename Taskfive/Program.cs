using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number : ");
        if (int.TryParse(Console.ReadLine(), out int N))
        {
            int sum = 0;
            for (int i = 1; i <= N; i++) sum += i;
            Console.WriteLine($"Sum from 1 to {N} is: {sum}");
        }
        
        int num = 1;
        Console.WriteLine("Numbers from 1 to 20 skipping multiples of 4, stopping at 15):");
        while (num <= 20)
        {
            if (num % 4 == 0) { num++; continue; }
            if (num == 15) break;
            Console.Write(num + " ");
            num++;
        }
        Console.WriteLine();

        int[] numbers = { 5, 10, 15, 20 };
        int total = 0;
        foreach (int number in numbers) total += number;
        Console.WriteLine("Sum of array elements: " + total);
    }
}