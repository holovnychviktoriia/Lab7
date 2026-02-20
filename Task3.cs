namespace Lab7;

public static class Task3
{
    public static void Run()
    {
        Console.WriteLine("Завдання 3");

        Func<double, double> discountCalculator = null!;
        discountCalculator += price => price * 0.95;
        discountCalculator += price => price * 0.90;
        discountCalculator += price => price - 100;

        Console.WriteLine(discountCalculator(1000));

        double result = 1000;
        foreach (var func in discountCalculator.GetInvocationList())
        {
            result = ((Func<double, double>)func)(result);
        }
        Console.WriteLine(result);
    }
}