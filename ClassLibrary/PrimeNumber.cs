public class PrimeNumber
{
    public string IdentifyPrimeOrNot()
    {
        uint number;
        while (!uint.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Error! Invalid integer.");
        }

        if (number <= 1)
        {
            return "It is not a prime number";
        }

        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0)
            {
                return "It is a not prime number";
            }
        }
        return "It is a prime number";
    }

}