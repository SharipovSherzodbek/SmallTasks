
public class PowerCalculator
{
    public int CalculatePower()
    {
        Console.WriteLine("Enter a number to raise to a power:");
        int number;
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Invalid input. Please enter a valid integer:");
        }

        Console.WriteLine("Enter an integer power level:");
        uint level;
        while (!uint.TryParse(Console.ReadLine(), out level))
        {
            Console.WriteLine("Invalid input. Please enter a valid non-negative integer:");
        }

        int result = 1;
        for (uint i = 0; i < level; i++)
        {
            result *= number;
        }
        return result;
    }
}

