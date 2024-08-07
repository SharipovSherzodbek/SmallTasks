public class ArmstrongNumbers
{
    public string ArmstrongOrNot()
    {

        int number = ReadNumber();

        int originalNumber = number;
        int sum = 0;
        int numerOfDigits = number.ToString().Length;

        while (number > 0)
        {
            int digit = number % 10;
            sum = sum + Power(digit, numerOfDigits);
            number = number / 10;
        }

        string armstrongOrNot = (sum == originalNumber)
            ? originalNumber + " is an Armstrong number!"
            : originalNumber + " is not an Armstrong number!";

        return armstrongOrNot;
    }

    private int ReadNumber()
    {
        int number;
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Invalid format! Please enter a valid format...");
        }
        return number;

    }

    public int Power(int baseValue, int exponent)
    {
        int result = 1;
        for (int i = 0; i < exponent; i++)
        {
            result *= baseValue;
        }
        return result;
    }
}

