using System;
using System.Collections.Generic;

public class Divisors
{
    public void FindDivisors()
    {
        Console.Write("Enter a number to find it: ");
        int number;
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer:");
        }

        List<int> divisors = new List<int>();

        for (int i = 2; i <= 10; i++)
        {
            if (number % i == 0)
            {
                divisors.Add(i);
            }
        }

        Console.Write("Here are the divisors: ");
        for (int i = 0; i < divisors.Count; i++)
        {
            if (i == divisors.Count - 1)
            {
                Console.Write(divisors[i]);
            }
            else
            {
                Console.Write(divisors[i] + ", ");
            }
        }
    }
}
