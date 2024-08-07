
using System;
using System.Threading.Channels;

public class QualityDivisors
{
    public string CountQualityDivisors()
    {
        int number = int.Parse(Console.ReadLine());

        if (number <= 0)
        {
            return "\"Number must be greater than 0.\"";
        }

        // Calculate the number of quality divisors
        int count = 0;
        for (int i = 2; i <= number; i++)
        {
            if (number % i == 0)
            {
                count++;
            }
        }

        return " " + count;
    }

}

