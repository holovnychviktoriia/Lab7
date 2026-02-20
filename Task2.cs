namespace Lab7;

public static class Task2
{
    public static void Run()
    {
        Console.WriteLine("Завдання 2");

        var terminal = new BankTerminal();

        terminal.OnMoneyWithdraw += amount => Console.WriteLine($"SMS: знято {amount} грн");
        terminal.OnMoneyWithdraw += amount => Console.WriteLine($"Лог: {amount} грн");

        terminal.Withdraw(500);
    }
}