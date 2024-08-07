public class CollectionOfExpenses
{
    public int CalculateExpenses()
    {
        Console.WriteLine("Enter the number of expenses:");
        int numberOfExpenses = int.Parse(Console.ReadLine());

        int[] expenses = new int[numberOfExpenses];

        for (int i = 0; i < numberOfExpenses; i++)
        {
            Console.WriteLine("Enter expense " + (i + 1) + ":");
            expenses[i] = int.Parse(Console.ReadLine());
        }

        int total = 0;
        foreach (int expense in expenses)
        {
            total += expense;
        }

        return total;
    }
}

