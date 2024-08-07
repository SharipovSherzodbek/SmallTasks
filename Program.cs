using System.Reflection.Emit;

namespace BasicKetmaKetlik3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("_____________ Task1 _____________");
            Console.WriteLine("To find a number prime or not enter an integer...");
            PrimeNumber primeOrNot = new PrimeNumber();
            Console.WriteLine(primeOrNot.IdentifyPrimeOrNot());

            Console.WriteLine("\n_____________ Task2 _____________");
            Console.WriteLine("Bo'luvchisiz sonlar(Divisors)!");
            Divisors divisors = new Divisors();
            divisors.FindDivisors(); 

            Console.WriteLine("\n_____________ Task3 _____________");
            Console.WriteLine("Level calculation!");
            PowerCalculator levelCalculation = new PowerCalculator();
            Console.WriteLine("The answer is: " + levelCalculation.CalculatePower()); 

            Console.WriteLine("\n_____________ Task4 _____________");
            Console.WriteLine("Calculate the sum of a collection of expenses!");
            CollectionOfExpenses harajatlar = new CollectionOfExpenses();
            Console.WriteLine("Total Expenses: " + harajatlar.CalculateExpenses());

            Console.WriteLine("\n_____________ Task5 _____________");
            Console.WriteLine("Enter a number to find Armstrong number or not!...");
            ArmstrongNumbers armstrongNum = new ArmstrongNumbers();
            Console.WriteLine(armstrongNum.ArmstrongOrNot()); 

            Console.WriteLine("\n_____________ Task6 _____________");
            Console.WriteLine("Enter a number to find qwantity Quality Divisors!...");
            QualityDivisors qd = new QualityDivisors();
            string result = qd.CountQualityDivisors();
            Console.WriteLine($"Number of quality divisors: {result}");
        }
    }
}
